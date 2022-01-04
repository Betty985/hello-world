package com.yuli.webcrawler;

import java.io.File;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Date;

import org.apache.lucene.analysis.Analyzer;
import org.apache.lucene.document.Document;
import org.apache.lucene.document.Field;
import org.apache.lucene.index.CorruptIndexException;
import org.apache.lucene.index.IndexReader;
import org.apache.lucene.index.IndexWriter;
import org.apache.lucene.index.IndexWriterConfig;
import org.apache.lucene.index.IndexWriterConfig.OpenMode;
import org.apache.lucene.queryParser.ParseException;
import org.apache.lucene.queryParser.QueryParser;
import org.apache.lucene.search.IndexSearcher;
import org.apache.lucene.search.Query;
import org.apache.lucene.search.ScoreDoc;
import org.apache.lucene.search.highlight.InvalidTokenOffsetsException;
import org.apache.lucene.store.Directory;
import org.apache.lucene.store.FSDirectory;
import org.apache.lucene.store.RAMDirectory;
import org.apache.lucene.util.Version;
import org.junit.Test;
import org.wltea.analyzer.lucene.IKAnalyzer;

public class DB {
    private static final String driverClassName="com.mysql.jdbc.Driver";
    private static final String url="jdbc:mysql://localhost:3306?useUnicode=true&characterEncoding=utf8";
    private static final String username="XXX";
    private static final String password="XXX";
    public static final String INDEX_PATH = "F:\\index"; 
    private static File indexFile = null; 
    private static final Version version = Version.LUCENE_36;
    private Directory directory = null;
    private IndexWriter indexwriter = null;
    private IKAnalyzer analyzer;

    private Connection conn;
    public DB() {
        directory = new RAMDirectory();
    }

    public IndexSearcher getSearcher(){
        try {
//            System.out.println("get..."+INDEX_PATH);
            IndexReader reader=IndexReader.open(directory);

            return new IndexSearcher(reader);
        } catch (CorruptIndexException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
        return null;
    }

    public Connection getConnection(){
        if(this.conn == null){
            try {
                Class.forName(driverClassName);
                conn = DriverManager.getConnection(url, username, password);
            } catch (ClassNotFoundException e) {
                e.printStackTrace();
            } catch (SQLException e) {
                e.printStackTrace();
            }

        }

        return conn;
    }

    private IKAnalyzer getAnalyzer(){
        if(analyzer == null){
            return new IKAnalyzer();
        }else{
            return analyzer;
        }
    }
@Test
    public void createIndex(){
	indexFile = new File(INDEX_PATH);     
    if(!indexFile.exists()) {     
        indexFile.mkdir(); 
    }     
    	long stime = new Date().getTime();
        Connection conn = getConnection();
        String sql = null;
        Statement stmt = null;
        PreparedStatement pstmt = null;
        ResultSet rs = null;
        if(conn == null){
            System.out.println("get the connection error...");
            return ;
        }
        try {
            sql = "USE crawler";
    		stmt = conn.createStatement();
    		stmt.executeUpdate(sql);
            sql = "SELECT contentID as id,URL2 as weburl, webTitle as title ,webContent as content,pubTime as time FROM webcontent";
			pstmt = conn.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
			rs = stmt.executeQuery(sql);
            IndexWriterConfig iwConfig = new IndexWriterConfig(version, new IKAnalyzer());
//            OpenMode.CREATE_OR_APPEND��ʾ������׷�ӵ����������ļ�
            iwConfig.setOpenMode(OpenMode.CREATE_OR_APPEND);
//            ʹ�ô��̱�������.�������д���һ��Ҫ�У���Ȼд����������
            directory = FSDirectory.open(indexFile);
            indexwriter = new IndexWriter(directory,iwConfig);
//          System.out.println("hello..."+directory);
			
           
            while(rs.next()){
                int id = rs.getInt("id");
                String weburl = rs.getString("weburl");
                String title = rs.getString("title");
                String content = rs.getString("content");
                String time = rs.getString("time");
                Document doc = new Document();
                doc.add(new Field("id", id+"",Field.Store.YES,Field.Index.NOT_ANALYZED));
                doc.add(new Field("weburl", weburl+"",Field.Store.YES,Field.Index.NOT_ANALYZED));
                doc.add(new Field("title", title+"",Field.Store.YES,Field.Index.ANALYZED));
//              System.out.println("hello..."+title);
                doc.add(new Field("content ", content +"",Field.Store.YES,Field.Index.ANALYZED));
                doc.add(new Field("time", time+"",Field.Store.YES,Field.Index.NOT_ANALYZED));
                indexwriter.addDocument(doc);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }finally{
            try {
            	long endTime = new Date().getTime();
                System.out.println("�⻨���� " + (endTime - stime)+ "���������������ӵ�����"+INDEX_PATH+"����ȥ!");
                if(indexwriter != null)
                indexwriter.close();
                rs.close();
                pstmt.close();
                if(!conn.isClosed()){
                    conn.close();
                }
            } catch (IOException e) {
                e.printStackTrace();
            } catch (SQLException e) {
                // TODO Auto-generated catch block
                e.printStackTrace();
            }
        }
    }

    public void searchTest(String field,String queryStr,int num) throws InvalidTokenOffsetsException{
         IndexSearcher isearcher = getSearcher();
         Analyzer analyzer =  getAnalyzer();
        //ʹ��QueryParser��ѯ����������Query����
        QueryParser qp = new QueryParser(version,field,analyzer);
        qp.setDefaultOperator(QueryParser.OR_OPERATOR);
        try {
            Query query = qp.parse(queryStr);
            ScoreDoc[] hits;
//          ��2������n����ʶ�ǣ� ȡ��ǰn��Ŀ������
            hits = isearcher.search(query, num).scoreDocs;
            System.out.println("����ǣ�");
            if(hits.length==0)
            	System.out.println("��Ǹ��û���ҵ������");
            for (int i = 0; i < hits.length; i++) {
                Document doc = isearcher.doc(hits[i].doc);
                System.out.println(doc.get(field)+" ");
            }
           
            directory.close();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (ParseException e) {
            e.printStackTrace();
        }

        }

   
    public static void main(String[] args) throws InvalidTokenOffsetsException {
        DB ld = new DB();
        ld.createIndex();
//        System.out.println("��������~~~");
//        ld.searchTest("title", "���� OR ����", 10);
        System.out.println("��������~~~");
        ld.searchTest("title", "\"����\"", 10);
//        System.out.println("ģ������~~~");
//        ld.searchTest("title", "\"����\"~1", 10);
//        System.out.println("ͨ�������~~~");
//        ld.searchTest("title", "����*", 10);
//        System.out.println("��������~~~");
//        ld.searchTest("title", "���� contentID:20", 10);
//        System.out.println("��Χ����~~~");
//        ld.searchTest("time", "[2021-05-14 TO 2022-01-02]", 100);     
        System.out.println("��������...");
        
    }
    
}
