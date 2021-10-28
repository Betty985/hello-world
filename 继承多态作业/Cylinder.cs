using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cylinder:Circle//圆柱体
    {
     private double h;

    public double H
    {
        get { return this.h; }
        set { this.h = value; }
    }


    //新增构造函数，Cylinder类的初始化实例
    public Cylinder():base(0,0,0) 
    {
        base.X = base.Y =base.R =0;  //base表示其基类
        this.h = 1.0;
    }

    //新增构造函数，Cylinder类的初始化实例
    public Cylinder(double x,double y, double r,double height):base(x,y,r)
    {
        base.X = x;
        base.Y = y;
        base.R = r;
        this.h=height;

    }

    //新增构造函数，Cylinder类的初始化实例
    public Cylinder(Circle circle, double height):base(circle.X, circle.Y,circle.R)
    {
        base.X = circle.X;
        base.Y = circle.Y;
        base.R = circle.R;
        this.h =height ;
    }

    //计算圆柱体的面积
    public override double Area()
    {
        return Math.PI * Math.Pow(this.R, 2)*2+Math.PI * this.Diameter()+this.h;

    }

    //计算圆柱体的体积
     public double Volume()
    {
        return Math.PI * Math.Pow(this.R, 2)*this.h;
    }
    public override string ToString()
    {
        return "圆心坐标 = [" + base.X + "]" + "[" + base.Y + "] ,半径 = " + base.R+", 高 = "+h;
    }

    ~Cylinder() { }
    }

