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
        int x;
        int y;
        int z;
        string name = "点";
        //实现接口
        public int perimeter()
        {
            int c = 0;
            //$ 特殊字符将字符串文本标识为内插字符串
            //Console.WriteLine($"{ name}周长是{ c}");
            Console.WriteLine($"{0} 周长是{1}", c, c);
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
    class Line : Point
    {

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
