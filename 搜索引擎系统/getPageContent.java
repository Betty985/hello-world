package com.netspider;

import java.text.ParseException;
import java.util.regex.Matcher;
//import java.util.regex.Matcher;
//import java.util.regex.Pattern;
import java.util.regex.Pattern;

import org.htmlparser.Node;
import org.htmlparser.NodeFilter;

//import javax.lang.model.util.Elements;

//import org.htmlparser.NodeFilter;
import org.htmlparser.Parser;
// HtmlParser对Visitor和Filter的方法进行了封装，定义了针对一些常用html元素操作的bean，简化对常用元素的提取操作。
// 根据提供的URL，获取此URL对应网页的纯文本信息
import org.htmlparser.beans.StringBean;
import org.htmlparser.filters.AndFilter;
import org.htmlparser.filters.HasAttributeFilter;
//import org.htmlparser.filters.HasAttributeFilter;
import org.htmlparser.filters.TagNameFilter;
import org.htmlparser.util.NodeList;
import org.htmlparser.util.ParserException;

public class getPageContent {

	public String getText(String url) throws ParseException {
//		用来从一个指定的URL获取移除了<SCRIPT></SCRIPT>和<PRE></PRE>之间代码的Html代码，
//		也可以用做Visitor，用来移除这两种标签内部的代码，采用StringBean.getStrings()来获取结果。 
	
		StringBean sb = new StringBean();

		//设置不需要得到的页面所包含的连接信息
		sb.setLinks(false);
		//设置将不间断的空格由正规空格替代
		sb.setReplaceNonBreakingSpaces(true);
		//设置将一系列空格由单一空格替代
		sb.setCollapse(true);
		//传入要解析的URL
		sb.setURL(url);
		//返回页面的纯文本信息
		return sb.getStrings();
		
	}
	
	public String getTitle(String url) throws ParserException {
		String tmp=null;
		Parser parser = null;
		try{
			parser = new Parser(url);
			parser.setEncoding("UTF-8");			
		}catch(Exception e) {
//			parser = new Parser(url);
//			parser.setEncoding("gb2312");
			e.printStackTrace();
		}
		TagNameFilter filter = new TagNameFilter("title");
		NodeList nl =parser.extractAllNodesThatMatch(filter);
		return nl.elementAt(0).toPlainTextString();
	}
	
	public String getPubTime(String url) {
		String pubTime = "";
		Parser parser = null;
		try {
			parser = new Parser(url);
			parser.setEncoding("UTF-8");
			NodeFilter filter = new AndFilter(new TagNameFilter("span"), 
					new HasAttributeFilter("class", "date"));
			NodeList list =parser.extractAllNodesThatMatch(filter);
			if (list == null || list.size() <= 0) {
				return null;
			}
			for (Node node : list.toNodeArray()) {// 只会执行一次
				pubTime = node.toPlainTextString().trim();
				pubTime = pubTime.substring(0, 11);
				break;
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
//		格式化
		pubTime=pubTime.replace("年","-");
		pubTime=pubTime.replace("月","-");
		pubTime=pubTime.replace("日","");
		System.out.println("hello  "+pubTime);
		return pubTime;
	}
//	public String getDescription(String url) {
//		String description = "";
//		Parser parser = null;
//		try {
//			parser = new Parser(url);
//			parser.setEncoding("UTF-8");
//			NodeFilter filter = new AndFilter(new TagNameFilter("meta"), 
//					new HasAttributeFilter("name", "description"));
//			NodeList list =parser.extractAllNodesThatMatch(filter);
//			if (list == null || list.size() <= 0) {
//				return null;
//			}
//			for (Node node : list.toNodeArray()) {// 只会执行一次
//				description = node.toPlainTextString().trim();
//				break;
//			}
//		} catch (Exception e) {
//			e.printStackTrace();
//		}
//		System.out.println("****************\n "+description);
//		return description;
//	}
}


