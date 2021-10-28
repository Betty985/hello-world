using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*********************************一个类定义的时候**************************************/
//无或internal: 只能在当前项目中访问该类
//public:可以在任何地方访问该类
//private:不能在任何地方访问该类
//abstract或internal abstract:类只能在当前项目中访问，不能实例化，只能供继承之用
//public abstract: 类可以在任何地方访问，不能实例化，只能供继承之用
//sealed 或internal sealed:类只能在当前项目中访问，不能供继承之用，只能实例化
//public sealed 类可以在任何地方访问，不能供继承之用，只能实例化
/*********************************一个类定义的时候**************************************/




//该类是所有二维图形的基类，定义为抽象类，表明不能被实例化
public abstract class Shape:Object 
{

    public int color;

    //构造函数默认状态,这个函数默认就有，可以不用写出来
    public Shape() { }

    //虚方法：这样做的好处是无论将派生类做何种类型隐式转换，都将调用派生类自己的方法。
    //派生类可以通过override重写这个虚方法
    public override string ToString(){ return null;}//重写了Object类的ToString()方法
    public virtual double Area() { return 0; }//求面积
    public virtual double Perimeter() { return 0; }//求周长
    
    
    //求圆周长，注意，这里没有用到虚方法，是为了用另一种多态方式“覆盖”来实现
    public double Diameter() { return 0; }

    ~Shape() { }//析构函数
}


