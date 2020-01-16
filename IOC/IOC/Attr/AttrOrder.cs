using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Attr
{
    public class AttrOrder
    {
        private ITest _test;

        //属性，接收依赖
        public ITest Test
        {
            set { _test = value; }
            get { return _test; }
        }

        public string Add()
        {
            return _test.Add();
        }
    }
}
