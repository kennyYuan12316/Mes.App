using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Model.CommModel
{
    public static class MapperExtension
    {
        /// <summary>
        /// 实体转换
        /// </summary>
        /// <typeparam name="T">源</typeparam>
        /// <typeparam name="S">转</typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static S EntityConvert<T, S>(this T source)
        {
            S target = Activator.CreateInstance<S>();
            var sType = source.GetType();
            var dType = typeof(S);
            foreach (PropertyInfo now in sType.GetProperties())
            {
                var mappers = now.GetCustomAttributes(typeof(MapperAttribute), false);
                // 没有特性，表示属性名一致
                if (mappers.Length == 0)
                {
                    var name = dType.GetProperty(now.Name);
                    if (name == null)
                        continue;
                    dType.GetProperty(now.Name).SetValue(target, now.GetValue(source));
                }
                else
                {
                    // 获取要转换成的属性名
                    MapperAttribute mapper = mappers[0] as MapperAttribute;
                    // 获取属性名对于的属性
                    var name = dType.GetProperty(mapper.Key);
                    if (name == null)
                        continue;
                    // 属性存在即赋值
                    dType.GetProperty(mapper.Key).SetValue(target, now.GetValue(source));
                }
            }
            return target;
        }

        /// <summary>
        /// 集合转换
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <param name="sourceList"></param>
        /// <returns></returns>
        public static List<S> EntityConvert<T, S>(this List<T> sourceList)
        {
            List<S> list = new List<S>();
            IEnumerator<T> enumerator = sourceList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                list.Add(EntityConvert<T, S>(enumerator.Current));
            }
            return list;
        }
    }

}
