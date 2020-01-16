using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            string method = invocation.TargetType.Name + "." + invocation.Method.Name;
            var args = string.Join(",", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray());

            NLoger.Info("start:" + method + ",params:" + args);
            invocation.Proceed();
            NLoger.Info("end:" + method + ",result:" + invocation.ReturnValue);
        }
    }
}
