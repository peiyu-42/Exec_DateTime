using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {//取得本月一日
        static void Main(string[] args)
        {
            //今天的日期
            DateTime today = DateTime.Today;
            Console.WriteLine($"今天的日期 {today:yyyy/MM/dd}");

            //本月第一天
            DateTime startMounth = today.AddDays(1- today.Day);
            Console.WriteLine($"本月的第一天是 {startMounth:yyyy/MM/dd}");
        }
    }
}
