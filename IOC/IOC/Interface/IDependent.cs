﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Interface
{
    public interface IDependent
    {
        void SetDependence(ITest test);//设置依赖项
    }
}
