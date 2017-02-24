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

            #region deom2 string with $
            //var N = 10;
            // 以前的寫法
            //string message = string.Format("WEB組所有成員在四月加薪，調整幅度為原薪水的{0}倍", N);            
            // C# 6 的寫法
            //string message = $"WEB組所有成員在四月加薪，調整幅度為原薪水的{N}倍";
            //Console.WriteLine(message);

            //var m = new member { id = 7, name = "Mike" };
            //string message2 = $"{m.name}的員工編號為{m.id}號";
            //Console.WriteLine(message2);
            #endregion
        }
    }
}
