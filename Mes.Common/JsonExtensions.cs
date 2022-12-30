using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Common
{
    public static class JsonExtensions
    {
        /// <summary>
        /// 将JSON字符串还原为对象
        /// </summary>
        /// <typeparam name="T">要还原的类型</typeparam>
        /// <param name="json">被还原的字符串</param>
        /// <returns></returns>
        public static T DeserializeObject<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
        /// <summary>
        /// 将对象序列化为Json字符串
        /// </summary>
        public static string SerializeObject(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
