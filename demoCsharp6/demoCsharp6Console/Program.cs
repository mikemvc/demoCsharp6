using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoCsharp6Console
{
    class Program
    {
        #region demo1
        public static string loadConnectionString(string connString)
        {
            if (string.IsNullOrEmpty(connString))
            {
                throw new ArgumentException("你又忘記傳送參數了，笨蛋", nameof(connString));
                // 以前的寫法為
                // throw new ArgumentException("你又忘記傳送參數了，笨蛋", "connString");
            }

            var result = System.Configuration.ConfigurationManager.ConnectionStrings[connString].ConnectionString;
            return result;

        }
        #endregion
        static void Main(string[] args)
        {
            #region demo1 nameof
            //string connString = loadConnectionString("");
            #endregion
        }
    }
}
