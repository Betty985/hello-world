using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class Triangle:Shape //Triangle类，包含三个Point，采用sealed,表示是继承树的根类
{
    private Point p1;
    private Point p2;
    private Point p3;
    Line l1;//没写访问控制符，相当于默认protected，只能被其派生类使用
    Line l2;
    Line l3;

    public Point P1
    {
        get { return this.p1; }
        set { this.p1 = value; }
    }

    public Point P2
    {
        get { return this.p2; }
        set { this.p2 = value; }
    }

    public Point P3
    {
        get { return this.p3; }
        set { this.p3 = value; }
    }
   

    //用点初始化Triangle类的实例
    public Triangle(Point point1, Point point2, Point point3)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
        this.l1 = new Line(p1,p2);
        this.l2 = new Line(p1,p3);
        this.l3 = new Line(p3,p2);
    }

    //用线初始化Triangle类的实例
    public Triangle(Line line1, Line line2, Line line3)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
    }

    //返回三角形的周长
    public override double Perimeter()
    {
       return l1.Length() + l2.Length() + l3.Length();
    }

    //返回三角形的面积
    public override double Area() 
    {  
       
        double p=(l1.Length() + l2.Length() + l3.Length())/2;
        return Math.Sqrt(p*(p-l1.Length())*(p-l2.Length())*(p-l3.Length()));
        //return 0;
        //you name it.
    }

    public bool IsEquicrural()//判断是否为等腰三角形
    {  
        if (l1.Length()==l2.Length()||l2.Length()==l3.Length()||l1.Length()==l3.Length())
        return true;
        else  return false; //you name it 
    }

    public bool IsEquilateral()//判断是否为等边三角形
    {  
        if (l1.Length()==l2.Length()&&l2.Length()==l3.Length()) return true;
        else  return false; //you name it 
    }

    public override string ToString()
      {     return "[" + this.p1.X + "," + this.p1.Y + "]," + "[" + this.p2.X + "," + this.p2.Y + "],"+ "[" + this.p3.X + "," + this.p3.Y + "]";
    //return null; //you name it.;
    }

    ~Triangle() { }
}