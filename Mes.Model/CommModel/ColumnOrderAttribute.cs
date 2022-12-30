using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.CommModel
{
    /// <summary>
    /// 自定义注解，用来标注excel列对应实体中的属性
    /// 比如  order = 1 代表第二列，使用在 DataTable转List时，将row[order] 赋值给对应的对象属性，使用反射技术进行处理
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple =false)]
    public class ColumnOrderAttribute : Attribute
    {
        public ColumnOrderAttribute(int order)
        {
            Order = order;
        }

        public int Order
        {
            get;set;
        }
    }
}
