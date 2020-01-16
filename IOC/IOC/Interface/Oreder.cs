using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Interface
{
    /// <summary>
    /// 实现类
    /// </summary>
    public class Oreder : IDependent
    {
        private ITest _test;

        public void SetDependence(ITest test)
        {
            _test = test;
        }

        public string Add()
        {
            return _test.Add();
        }
    }
}
