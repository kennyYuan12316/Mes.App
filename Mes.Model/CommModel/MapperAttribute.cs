using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.CommModel
{
    // 一个自定义特性
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class MapperAttribute : Attribute
    {
        public MapperAttribute(string Key)
        {
            this.Key = Key;
        }

        public string Key { get; set; }
    }

}
