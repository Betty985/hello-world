using System;

namespace Shape
{
    interface IShape
    {
        int perimeter();
        int area();
        void draw();
    }
    #region Point类
    public class Point : IShape
    {
        public int x;
        public int y;
        string name = "点";
        public Point()
        {

        }
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
            
        }
        //实现接口
        public int perimeter()
        {
            int c = 0;
            //$ 特殊字符将字符串文本标识为内插字符串
            //Console.WriteLine($"{ name}周长是{ c}");
            Console.WriteLine($"{0} 周长是{1}", name, c);
            return c;
        }
        public int area()
        {
            int s = 0;
            return s;
        }
        public void draw()
        { }
    }
    #endregion
    #region Line类
   public  class Line : Point
    {
        public int xl;
        public int yl;
        string name = "线";
        public Line()
        {

        }
        public  Line(int x,int y,int xl,int yl)
        {
            this.x= x;
            this.y = y;
            this.xl = xl;
            this.yl = yl;
        }
    }
    #endregion
    class TestMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
