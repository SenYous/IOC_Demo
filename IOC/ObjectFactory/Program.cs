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
    class Program
    {
        static void Main(string[] args)
        {
            ITest test = Factory.Create();
            Console.WriteLine(test.Add());
            Console.WriteLine(test.Add2());

            Console.ReadKey();
        }
    }
}
