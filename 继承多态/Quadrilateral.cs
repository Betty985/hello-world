using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    #region 四边形类
    public class Quadrilateral : Line
    {
        protected dot d3, d4;
        //隐藏
        protected new string name = "四边形";
        public Quadrilateral()
        {
        }
        public Quadrilateral(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
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
            int s, s1, s2;
            s1 = (1 / 2) * (d1.x * d2.y + d2.x * d3.y + d3.x * d1.y - d1.x * d3.y - d2.x * d1.y - d3.x * d2.y);
            s2 = (1 / 2) * (d4.x * d2.y + d2.x * d3.y + d3.x * d4.y - d4.x * d3.y - d2.x * d4.y - d3.x * d2.y);
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
