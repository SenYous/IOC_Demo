using IOC.Attr;
using IOC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 构造函数注入
            ///此处将依赖对象Test的创建和绑定转移到Order类的外部实现，
            ///解除了Test和Order的耦合关系
            ///如更换数据库（sqlserver），重新定义Test类即可
            //Test test = new Test();//在外部创建依赖对象
            //Order order = new Order(test);//通过构造函数注入依赖

            //Console.WriteLine(order.Add());
            #endregion

            #region 属性注入
            ///给属性赋值，从而传递依赖
            //Test test = new Test();//在外部创建依赖对象
            //AttrOrder order = new AttrOrder();
            //order.Test = test;//属性赋值
            //Console.WriteLine(order.Add());
            #endregion

            #region 接口注入
            Test test = new Test();//在外部创建依赖对象
            Oreder order = new Oreder();

            order.SetDependence(test);//传递依赖

            Console.WriteLine(order.Add());
            #endregion
            Console.ReadKey();
        }
    }
}
