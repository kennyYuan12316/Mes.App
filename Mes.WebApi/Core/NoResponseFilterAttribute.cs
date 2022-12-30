using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mes.WebApi.Core
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true)]
    public class NoResponseFilterAttribute: System.Attribute
    {
    }
}