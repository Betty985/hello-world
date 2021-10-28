using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public  class Line : Shape      //Line类，继承于Shape类，有自己的私有成员point1和point2

{//私有变量(Point类型，如果Point类的类型是private,则不能被访问，如果是protected，则该类的基类可以直接访问该变量，不需要get和set
 
    private Point p1;    
    private Point p2;

    public Point P1////控制变量point1的可访问性
    {
        get { return this.p1; }
        set { this.p1 = value; }//value是一个局部变量，用来赋给变量point1值
    }

    public  Point P2
    {
        get { return this.p2; }
        set { this.p2 = value; }
    }


    //默认构造函数,如无必要可以不写
    public  Line()
    {
    }

    //新增构造函数：用指定两点初始化Line新实例
    public Line(Point point1, Point point2)
    {
        this.p1 = point1;
        this.p2 = point2;
    }

    public double Length()//长度
    {
        return Math.Sqrt(Math.Pow((this.p1.X - this.p2.X),2)  + Math.Pow((this.p1.Y - this.p2.Y), 2));
    }

    public double Slope()//斜率
    {
        if ((p2.X - p1.X) != 0)
            return (this.p1.Y - this.p1.Y) / (this.p2.X - this.p1.X);
        else
            return 99999;
    }

    //直线的 a b c系数
    public double ACoefficient()
    {  return p2.Y - p1.Y;}


    public double BCoefficient()
    {  return p2.X - p1.X;}


    public double CCoefficient()
    {  return p2.X * p1.Y - p1.X * p2.Y;}


    //重写Shape类的虚方法
    public override string ToString()
    {
        return "[" + this.p1.X + "," + this.p1.Y + "]," + "[" + this.p2.X + "," + this.p2.Y + "]";
    }


    ~Line() { }
}


