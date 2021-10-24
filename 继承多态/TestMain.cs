using System;

using System.Collections.Generic;

using System.Data;

using System.ComponentModel;

using System.Drawing;

using System.Drawing.Drawing2D;

using System.Drawing.Imaging;

namespace Shape
{    //接口
    interface IShape
    {
        int perimeter();
        int area();
        void draw();
    }
    //结构 
    public struct dot
    {
        public int x;
        public int y;
        public int z;
    }
    #region Point类
    public class Point : IShape
    {
        protected  dot d1;
         /// <summary>
         /// 字段
        /// </summary>
        protected string name = "点";
        /// <summary>
        /// 属性
        /// </summary>
        public string Name {
            get { return name; }
        }
        public Point()
        {

        }
        public Point(int x, int y)
        {
            d1.x = x;
            d1.y = y;
        }
        public Point(int x,int y,int z)
        {
           d1.x = x;
           d1.y = y;
           d1.z = z;

        }
        //实现接口
        public virtual int perimeter()
        {
            int c = 0;
            //格式占位符
            Console.WriteLine("{0}的周长是{1}", name, c);
            return c;
        }
        public virtual int area()
        {
            int s = 0;
            Console.WriteLine("{0}的面积是{1}", name, s);
            return s;
        }
        public virtual void draw()
        { }

    }
    #endregion

    #region Line类
   public  class Line : Point
    {
        protected dot d2;
        //隐藏
        protected new string name = "线";
        public Line()
        {

        }
        public Line(int x1, int y1, int x2, int y2)
        {
            d1.x = x1;
            d1.y = y1;
            d2.x = x2;
            d2.y = y2;
        }
        public Line(int x1, int y1, int z1,int x2, int y2, int z2)
        {
            d1.x = x1;
            d1.y = y1;
            d1.z = z1;
            d2.x = x2;
            d2.y = y2;
            d2.z = z2;
        }
       public override int perimeter()
        {
            int c = (int)Math.Sqrt(Math.Pow(d1.x - d2.x, 2.0) + Math.Pow(d1.y - d2.y, 2.0));
            //$ 特殊字符将字符串文本标识为内插字符串 。 内插字符串是可能包含内插表达式的字符串文本 。
            //将内插符串解析为结果字符串时，带有内插表达式的项会替换为表达式结果的字符串表示形式。
            Console.WriteLine($"{name}的长度是{c}");
            return c;
        }
        public override int area()
        {
            int s = 0;
            Console.WriteLine("{0}的面积是{1}", name, s);
            return s;
        }
        public override void draw()
        {

        }
    }
    #endregion

   
    class TestMain
    {
        static void Main(string[] args)
        {
            Parallelogram l1 = new Parallelogram();
            l1.perimeter();
            l1.area();
            l1.draw(); 
            //类型数组
            string[] type = { "点", "线","三角形","圆","圆柱","四边形","梯形","平行四边形","菱形","长方形","正方形"};
            Console.WriteLine("请选择：\n");
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine(i + " : " + type[i]);
            }
            Console.WriteLine("按退出（Esc）键退出! \n");       
            do
            {
                char a = (char)Console.Read();
                switch (a)
                {
                    case '0':
                        {
                            Point p = new Point();
                            p.perimeter();
                            p.area();
                            p.draw(); break;
                        }
                    case '1':
                        {
                            Line l = new Line(1,2,3,5);
                            l.perimeter();
                            l.area();
                            l.draw(); break;
                        }
                    case '2': {
                            Triangle t1 = new Triangle(0,0,0,4,3,0);
                            t1.perimeter();
                            t1.area();
                            t1.draw(); break; }
                    case '3':
                        {
                            Circle l = new Circle();
                            l.perimeter();
                            l.area();
                            l.draw(); break; }
                    case '4':
                        {
                            Cylinder l = new Cylinder();
                            l.area();
                            l.volume();
                            l.draw(); break; }
                    case '5':
                        {
                            Quadrilateral l = new Quadrilateral();
                            l.perimeter();
                            l.area();
                            l.draw(); break; }
                    case '6':
                        {
                            Trapezoid l = new Trapezoid();
                            l.perimeter();
                            l.area();
                            l.draw(); break; }
                    case '7':
                        {
                            Parallelogram l = new Parallelogram();
                            l.perimeter();
                            l.area();
                            l.draw(); break; }
                    case '8':
                        {
                            Rhombus l = new Rhombus();
                            l.perimeter();
                            l.area();
                            l.draw(); break; }
                    case '9':
                        {
                            Rectangle l = new Rectangle(0,0,0,2,4,2,4,0);
                            l.perimeter();
                            l.area();
                            l.draw(); break; }
                    default:
                        {
                            Quadrate l = new Quadrate(0,0,0,1,1,0,1,1);
                            l.perimeter();
                            l.area();
                            l.draw(); break; }
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("Hello World!");
        }
    }
}
