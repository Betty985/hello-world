using System;

public class TestMain
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(37, 43, 2.5);
       
        Console.WriteLine("该圆的圆心的坐标是:{0},{1}", circle.X, circle.Y);
        circle.X = 20;
        circle.Y = 20;

        Console.WriteLine("该圆的新圆心坐标是:{0},{1}", circle.X, circle.Y);
        Point p1=new Point(0,2);
        Console.WriteLine("点的坐标是:{0}" ,p1.ToString());
        Point p2=new Point(0,0);
        Console.WriteLine("点的坐标是:{0}" ,p2.ToString());
        Point p3=new Point(2,6);
        Console.WriteLine("点的坐标是:{0}" ,p3.ToString());
        Point p4=new Point(2,0);
        Console.WriteLine("点的坐标是:{0}" ,p4.ToString());
        Line l1= new Line(p1,p2);
        Console.WriteLine("线的长度是：{0}\n线的斜率是：{1}\n线的a系数是：{2}",l1.Length(),l1.Slope(),l1.ACoefficient());
        Triangle t1=new Triangle(p1,p2,p3);
        Console.WriteLine("三角形的面积是：{0}\n是否为等腰三角形：{1}",t1.Area(),t1.IsEquicrural());
        Rhombus r1=new Rhombus(p1,p2,p3,p4);
        Console.WriteLine("是否为菱形：{0}",r1.IsRhombus());
        Cylinder c1= new Cylinder(circle,3.0);
        Console.WriteLine(c1.ToString());
        Console.WriteLine("圆柱体的体积为：{0}",c1.Volume());
        Rectangle r2 = new Rectangle(p1,p2,p3,p4);
        Console.WriteLine("是否为长方形：{0}",r2.IsRectangle());
        Console.WriteLine("\n\nHello World!");
        Console.WriteLine("  ————张艳慧");
        Console.ReadLine();
    }
}
