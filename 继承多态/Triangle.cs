using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    #region 三角形类
    public class Triangle : Line
    {
        protected dot d3;
        //隐藏
        protected new string name = "三角形";
        public Triangle()
        {
        }
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            d1.x = x1;
            d1.y = y1;
            d2.x = x2;
            d2.y = y2;
            d3.x = x3;
            d3.y = y3;
        }
        //public Triangle(int x1, int y1, int z1, int x2, int y2, int z2, int x3, int y3, int z3)
        //{
        //    d1.x = x1;
        //    d1.y = y1;
        //    d1.z = z1;
        //    d2.x = x2;
        //    d2.y = y2;
        //    d2.z = z2;
        //    d3.x = x3;
        //    d3.y = y3;
        //    d3.z = z3;
        //}
        public override int perimeter()
        {
            int c;
            int L1 = (int)Math.Sqrt(Math.Pow(d1.x - d2.x, 2.0) + Math.Pow(d1.y - d2.y, 2.0));
            int L2 = (int)Math.Sqrt(Math.Pow(d1.x - d3.x, 2.0) + Math.Pow(d1.y - d3.y, 2.0));
            int L3 = (int)Math.Sqrt(Math.Pow(d3.x - d2.x, 2.0) + Math.Pow(d3.y - d2.y, 2.0));
            c = L1 + L2 + L3;//周长
            Console.WriteLine("{0}的周长是{1}", name, c);
            return c;
        }
        public override int area()
        {
            int s;
            int c;
            int L1 = (int)Math.Sqrt(Math.Pow(d1.x - d2.x, 2.0) + Math.Pow(d1.y - d2.y, 2.0));
            int L2 = (int)Math.Sqrt(Math.Pow(d1.x - d3.x, 2.0) + Math.Pow(d1.y - d3.y, 2.0));
            int L3 = (int)Math.Sqrt(Math.Pow(d3.x - d2.x, 2.0) + Math.Pow(d3.y - d2.y, 2.0));
            c = L1 + L2 + L3;//周长
            double p = c / 2; ;
            s = (int)Math.Sqrt(p * (p - L1) * (p - L2) * (p - L3));
            Console.WriteLine("{0}的面积是{1}", name, s);
            return s;
        }
        public override void draw()
        {

        }
    }
    #endregion
}
