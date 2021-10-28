using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle:Parallelogram//长方形
 {
    //用点初始化Rectangle类的实例
    public Rectangle(Point point1, Point point2, Point point3,Point point4)
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

    //用线初始化Rectangle类的实例
    public Rectangle(Line line1, Line line2, Line line3,Line line4)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.l4 = line4;
    }

    //判断是不是长方形
    public bool IsRectangle()
    { 
         double l5 = Math.Pow(p4.X - p2.X, 2.0) + Math.Pow(p4.Y - p2.Y, 2.0);
        if(Math.Pow(l2.Length(),2.0)+Math.Pow(l3.Length(),2.0)==l5||Math.Pow(l1.Length(),2.0)+Math.Pow(l3.Length(),2.0)==l5) return true;
       else return false;
    }

    //返回长方形的面积
    public override double Area() 
    {      if(l1.Slope()==l2.Slope()) return l1.Length()*l3.Length();
            else return l1.Length()*l2.Length();
        //return 0;
        //you name it.
    }
    ~Rectangle() { }
    //you can define.
}

