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

        #region demo3
        //public class member
        //{
        //    public int id { get; set; }
        //    public string name { get; set; }
        //}
        #endregion

        #region demo4
        public class member
        {
            public int id { get; set; }
            public string name { get; set; }
            public string fullName { get; set; }
            // C# 6.0 的自動實作屬性 (在以前必須指定私有欄位才能設定屬性的預設值)
            public string firstName { get; } = "mike";
            /* 以前的寫法為 
             *  private string _lastName = "mike";
             *  public string lastName { get { return _lastName; } }
             */
            // 使用表示式來作為屬性初始值
            public string lastName => fullName.Split(',')[1];
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

            #region demo3 Null propagation
            //// 首先宣告一個member物件，並將他設為NULL來模擬取不到值的狀況
            //member m = null;
            //// 接者直接取他的ID值，此時發現沒有印出值
            //Console.WriteLine($"kui的員工編號為 {m?.id} 號");
            //// 再次存取他的name值，如果取不到，就給他一個預設值『kui』
            //Console.WriteLine($"員工七號的姓名為{m?.name ?? "kui"}，號稱『台中金成舞』");
            #endregion

            #region demo4 Expression Bodied Auto-Properties 自動的屬性初始化設定
            //var m = new member { id = 1, name = "", fullName = "mike,wang" };
            //Console.WriteLine(m.lastName);  // 印出自動實作屬性的 lastName
            //// 使用反射方法，來取得物件的所有屬性(property)，不包含欄位(field)
            //Type type = m.GetType();
            //foreach (var property in type.GetProperties())
            //    Console.WriteLine($"屬性：{property.Name}");
            //Console.WriteLine($"firstName沒有定義，自動實作屬性的初始值為 {m.firstName}");
            #endregion

            Console.Read();
        }
    }
}
