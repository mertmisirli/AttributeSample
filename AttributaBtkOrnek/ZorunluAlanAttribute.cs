﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributaBtkOrnek
{
    [AttributeUsage(AttributeTargets.Field,AllowMultiple = true,Inherited = true)]
    public class ZorunluAlanAttribute : Attribute
    {

    }
}
