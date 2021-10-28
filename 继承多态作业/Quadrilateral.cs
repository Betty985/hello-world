using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Quadrilateral:Shape//四边形类
{
   public  Point p1;
   public  Point p2;
   public  Point p3;
   public  Point p4;
   public Line l1;
   public Line l2;
   public Line l3;
   public Line l4;

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
   
    public Point P4
    {
        get { return this.p4; }
        set { this.p4 = value; }
    }
    public Quadrilateral()
    {

    }
    //用点初始化Quadrilateral类的实例
    public Quadrilateral(Point point1, Point point2, Point point3,Point point4)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
        this.p4 = point4;
        this.l1 = new Line(p1,p2);
        this.l2 = new Line(p1,p4);
        this.l3 = new Line(p3,p4);
        this.l4 = new Line(p3,p2);
    }

    //用线初始化Quadrilateral类的实例
    public Quadrilateral(Line line1, Line line2, Line line3,Line line4)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.l4 = line4;
    }

    //返回四边形的周长
    public override double Perimeter()
    {
       return l1.Length() + l2.Length() + l3.Length()+l4.Length();
    }

    //返回四边形的面积
    public override double Area() 
    {  
            double l5 = Math.Sqrt(Math.Pow(p4.X - p2.X, 2.0) + Math.Pow(p4.Y - p2.Y, 2.0));
            double p = (l1.Length() + l2.Length() + l5) / 2; ;
            double s1 = Math.Sqrt(p * (p - l1.Length()) * (p - l2.Length()) * (p - l5));
            double p1 = (l5 + l4.Length() + l3.Length()) / 2; ;
            double s2 = Math.Sqrt(p1 * (p1 - l5) * (p1 - l4.Length()) * (p1 - l3.Length()));
            double s = s1 + s2;
            return s;
        //return 0;
        //you name it.
    }


    public override string ToString()
      {
         return "[" + this.p1.X + "," + this.p1.Y + "]," + "[" + this.p2.X + "," + this.p2.Y + "],"+ "[" + this.p3.X + "," + this.p3.Y + "]"+"[" + this.p4.X + "," + this.p4.Y + "]";
     //return null; //you name it.;
    }

    //you define
    ~Quadrilateral() { }
}

