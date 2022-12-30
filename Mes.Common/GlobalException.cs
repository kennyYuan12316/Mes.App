using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Common
{
    public class GlobalException : Exception
    {
        public string [] param{ get; set; }


        public GlobalException(string code) : base(code)
        {
            
        }

        public static GlobalException message(string code)
        {
            var ex = new GlobalException(code);
            ex.param = null;
            return ex;
        }


        public static GlobalException message(string code,params string [] param)
        {
            var ex = new GlobalException(code);
            ex.param = param;
            return ex;
        }
    }
}
