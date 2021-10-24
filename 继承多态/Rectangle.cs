using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace Shape
{
    #region 长方形类
    public class Rectangle : Parallelogram
    {
        protected new string name = "长方形";
        public Rectangle()
        {
        }
        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            d1.x = x1;
            d1.y = y1;
            d2.x = x2;
            d2.y = y2;
            d3.x = x3;
            d3.y = y3;
            d4.x = x4;
            d4.y = y4;
        }
        public override int perimeter()
        {
            int c;
            int L1 = (int)Math.Sqrt(Math.Pow(d1.x - d2.x, 2.0) + Math.Pow(d1.y - d2.y, 2.0));
            int L2 = (int)Math.Sqrt(Math.Pow(d1.x - d3.x, 2.0) + Math.Pow(d1.y - d3.y, 2.0));
            int L3 = (int)Math.Sqrt(Math.Pow(d3.x - d4.x, 2.0) + Math.Pow(d3.y - d4.y, 2.0));
            int L4 = (int)Math.Sqrt(Math.Pow(d4.x - d2.x, 2.0) + Math.Pow(d4.y - d2.y, 2.0));
            c = L1 + L2 + L3 + L4;//周长
            Console.WriteLine("{0}的周长是{1}", name, c);
            return c;
        }
        public override int area()
        {
            int s,s1,s2;
            int L1 = (int)Math.Sqrt(Math.Pow(d1.x - d2.x, 2.0) + Math.Pow(d1.y - d2.y, 2.0));
            int L2 = (int)Math.Sqrt(Math.Pow(d1.x - d3.x, 2.0) + Math.Pow(d1.y - d3.y, 2.0));
            int L3 = (int)Math.Sqrt(Math.Pow(d3.x - d2.x, 2.0) + Math.Pow(d3.y - d2.y, 2.0));
            int L4 = (int)Math.Sqrt(Math.Pow(d4.x - d2.x, 2.0) + Math.Pow(d4.y - d2.y, 2.0));
            double p =(L1 + L2 + L3 )/ 2; ;
            s1 = (int)Math.Sqrt(p * (p - L1) * (p - L2) * (p - L3));
            double p1 = (L4 + L2 + L3) / 2; ;
            s2 = (int)Math.Sqrt(p1 * (p1- L4) * (p1 - L2) * (p1 - L3));
            s = s1 + s2;
            Console.WriteLine("{0}的面积是{1}", name, s);
            return s;
        }
        public override void draw()
        {

        }
     
    }
    #endregion
}
