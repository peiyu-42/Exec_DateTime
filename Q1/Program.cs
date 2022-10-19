using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{//計算三天後 DVD 應歸還時間
    internal class Program
    {
        static void Main(string[] args)
        {
            //現在的時間
            DateTime now = DateTime.Now;

            //三天後的日期
            var afterThreeDays = now.AddDays(3);

            Console.WriteLine($"今天的日期 {now:yyyy/MM/dd}");
            Console.WriteLine($"歸還的日期 {afterThreeDays:yyyy/MM/dd}");
        }
    }
}
