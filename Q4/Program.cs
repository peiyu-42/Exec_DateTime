using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {//取得本月最後一天
        static void Main(string[] args)
        {
            //今天的日期
            DateTime today = DateTime.Today;
            Console.WriteLine($"今天的日期 {today:yyyy / MM / dd}");

            //下個月第一天
            var nextMonth = today.AddMonths(1);
            var nextMonth1 = nextMonth.AddDays(1 - nextMonth.Day);
            Console.WriteLine($"下個月第一天 {nextMonth1:yyyy / MM / dd}");

            //本月最後一天，下個月的第一天減一天
            var endMonth = nextMonth1.AddDays(-1);
            Console.WriteLine($"本月最後一天 {endMonth: yyyy / MM / dd}");            

        }
    }
}
