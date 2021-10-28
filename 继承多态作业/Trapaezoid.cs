using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Trapaezoid:Quadrilateral//梯形类
{ 
    public Trapaezoid()
    {

    }
    //用点初始化Trapaezoid类的实例
    public Trapaezoid(Point point1, Point point2, Point point3,Point point4)
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

    //用线初始化Trapaezoid类的实例
    public Trapaezoid(Line line1, Line line2, Line line3,Line line4)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.l4 = line4;
    }

    //判断是不是梯形
    public bool IsTrapaezoid()
    { 
        if(l1.Slope()==l2.Slope()||l1.Slope()==l3.Slope()||l1.Slope()==l4.Slope()||l2.Slope()==l3.Slope()||l2.Slope()==l4.Slope()||l3.Slope()==l4.Slope()) return true;
       else return false;
    }
    public bool IsEquicruralTrapaezoid()//判断是否为等腰梯形
    {  
       if(l1.Length()==l2.Length()||l1.Length()==l3.Length()||l1.Length()==l4.Length()||l2.Length()==l3.Length()||l2.Length()==l4.Length()||l3.Length()==l4.Length()) return true;
        else  return false; //you name it 
    }

    //you define
    ~Trapaezoid() { }
}

