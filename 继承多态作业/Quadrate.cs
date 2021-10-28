using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Quadrate:Rhombus//正方形
    {
    //用点初始化Quadrate类的实例
    public Quadrate(Point point1, Point point2, Point point3,Point point4)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
        this.p4 = point4;
    }

    //用线初始化Quadrate类的实例
    public Quadrate(Line line1, Line line2, Line line3,Line line4)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.l4 = line4;
    }

    //判断是不是正方形
    public bool IsQuadrate()
    { 
       double l5 = Math.Pow(p4.X - p2.X, 2.0) + Math.Pow(p4.Y - p2.Y, 2.0);
       double a = Math.Pow(l1.Length(),2.0);
       double b = Math.Pow(l2.Length(),2.0);
       double c = Math.Pow(l3.Length(),2.0);
        if(a+b==l5||a+c==l5) return true;
       else return false;
    }

    ~Quadrate() { }
    }
  
