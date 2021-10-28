using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Point : Shape 
{
    private double x; //私有变量，如果是protected则
    public double X //公共属性。控制成员x的可访问性，如果成员是大写的X,那么这里应该是_X
    {
        get { return this.x; }
        set { this.x = value; }
    }

    private double y;//获取y点坐标
    public double Y
    {
        get { return this.y; }
        set { this.y = value; }
    }


    //修改构造函数，用原点值(0,0)初始化Point类的新实例。
    public Point()
    {
        this.x = this.y = 0;
    }

    //用指定坐标初始化Point类的新实例
    public Point(double xco, double yco)
    {
        this.x = xco;
        this.y = yco;
    }
    //重写Shape类的虚方法
    
    public override double Perimeter()
    {
        return 0;
    }


  
    public override string ToString()
    {
        return "[" + this.x + " , " + this.y + "]";
    }


}


