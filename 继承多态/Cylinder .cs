using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    #region 圆柱类
    public class Cylinder : Circle
    {
        protected int h;
        //隐藏
        protected new string name = "圆柱";
        public Cylinder()
        {

        }
        public Cylinder(int x1, int y1, int r, int h)
        {
            d1.x = x1;
            d1.y = y1;
            this.r = r;
            this.h = h;
        }
        public override int perimeter()
        {
            return 1024;
        }
        public override int area()
        {
            int s = 2 * (int)Math.PI * r * r + h * Convert.ToInt32(2 * r * Math.PI);
            Console.WriteLine("{0}的面积是{1}", name, s);
            return s;
        }
        public int volume()
        {
            int v = (int)Math.PI * r * r * h;
            Console.WriteLine("{0}的体积是{1}", name, v);
            return v;
        }
        public override void draw()
        {

        }
    }
    #endregion
}
