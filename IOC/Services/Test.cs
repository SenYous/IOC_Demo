using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services
{
    public class Test : ITest
    {
        public string Add()
        {
            return "添加成功！";
        }

        public string Add2()
        {
            return "添加2成功！";
        }
    }
}