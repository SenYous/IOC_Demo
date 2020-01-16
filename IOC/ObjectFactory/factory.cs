using Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectFactory
{
    public class Factory
    {
        /// <summary>
        /// 配置文件+反射
        /// </summary>
        /// <returns></returns>
        public static ITest Create()
        {
            string classModule = ConfigurationManager.AppSettings["test"];
            Assembly assemly = Assembly.Load(classModule.Split(',')[1]);
            Type type = assemly.GetType(classModule.Split(',')[0]);
            //CreateInstance:使用指定类型的默认构造函数来创建该类型的实例。
            return (ITest)Activator.CreateInstance(type);
        }
    }
}
