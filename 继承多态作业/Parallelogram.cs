using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Parallelogram:Trapaezoid//平行四边形
    { 
     public Parallelogram()
    {

    }
    //用点初始化Parallelogram类的实例
    public Parallelogram(Point point1, Point point2, Point point3,Point point4)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
        this.p4 = point4;
    }

    //用线初始化Parallelogram类的实例
    public Parallelogram(Line line1, Line line2, Line line3,Line line4)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.l4 = line4;
    }

    //判断是不是平行四边形
    public bool IsParallelogram()
    { 
        if (l1.Slope()==l2.Slope()&&l4.Slope()==l3.Slope()) return true;
        else if(l1.Slope()==l4.Slope()&&l2.Slope()==l3.Slope())return true;
        else if(l1.Slope()==l3.Slope()&&l2.Slope()==l4.Slope()) return true;
            else return false;
    }

    ~Parallelogram() { }
      //you define
    }

