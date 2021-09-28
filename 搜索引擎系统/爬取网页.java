import java.io.*;
import java.net.*;

import javax.swing.text.html.HTMLDocument.HTMLReader.SpecialAction;
public class RetrivePage{
    public static String downloadPage(String path){
        try {   
        URL pageURL=new URL(path);
        BufferedReader reader=new BufferedReader(new InputStreamReader(pageURL.openStream()));
        String line;
        StringBuilder pageBuffer=new StringBuilder();
        while((line=reader.readLine())!=null){
            pageBuffer.append(line);
        }
        return pageBuffer.toString();
    } catch (Exception e) {
        //TODO: handle exception
        System.out.println("hi");
    }
    return "hello";
    }
    public static void main(String []args){
        System.out.println(RetrivePage.downloadPage("http://www.lietu.com"));
    }
}
