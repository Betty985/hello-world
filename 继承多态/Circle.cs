using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    #region 圆类
    public class Circle : Point
    {
        protected int r;
        //隐藏
        protected new string name = "圆";
        public Circle()
        {

        }
        public Circle(int x1, int y1, int r)
        {
            d1.x = x1;
            d1.y = y1;
            this.r = r;
        }
        public Circle(int x1, int y1, int z1, int r)
        {
            d1.x = x1;
            d1.y = y1;
            d1.z = z1;
            this.r = r;
        }
        public override int perimeter()
        {
            int c = Convert.ToInt32(2 * r * Math.PI);
            //$ 特殊字符将字符串文本标识为内插字符串
            //Console.WriteLine($"{ name}周长是{ c}");
            Console.WriteLine("{0}的周长是{1}", name, c);
            return c;
        }
        public override int area()
        {
            int s = (int)Math.PI * r * r;
            Console.WriteLine("{0}的面积是{1}", name, s);
            return s;
        }
        public override void draw()
        {

        }
    }
    #endregion
}
