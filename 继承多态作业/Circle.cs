using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Circle类继承Point类,它由一个表示圆心的点和一个表示半径变量组成，但是由于已经继承了Point类，因此不需要再次定义点
public class Circle:Point
{
    
    private double r;

    public double R
    {
        get { return this.r; }
        set { this.r = value; }
    }


    //新增构造函数，Circle类的初始化实例
    public Circle():base(0,0) 
    {
        base.X = base.Y = 0;  //base表示其基类
        this.r = 1.0;
    }

    //新增构造函数，Circle类的初始化实例
    public Circle(double x,double y, double radius):base(x,y)
    {
        this.X = x;
        this.Y = y;
        this.r = radius;
    }

    //新增构造函数，Circle类的初始化实例
    public Circle(Point point, double radius):base(point.X, point.Y)
    {
        base.X = point.X;
        base.Y = point.Y;
        this.r = radius;
    }

    //返回圆的直径
    public new double Diameter()
    {
        return this.r * 2;
    }

    //返回圆的周长
    public double CircumFerence()
    {
        return Math.PI * this.Diameter();//如果类中只有一个叫Diameter的成员，则可以省略this关键字
    }

    //计算圆的面积
    public override double Area()
    {
        return Math.PI * Math.Pow(this.r, 2);

    }

    public override string ToString()
    {
        return "圆心坐标 = [" + base.X + "]" + "[" + base.Y + "] ,半径 = " + r;
    }

    ~Circle() { }

}