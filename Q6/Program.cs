using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{//根據日期, 傳回今天是本月的上旬, 中旬或下旬
    internal class Program
    {
        static void Main(string[] args)
        {
            //今天的日期
            DateTime today = DateTime.Today;
            Console.WriteLine($"今天的日期 {today:yyyy / MM / dd}");

            // 今天是幾號
            int dayToday = today.Day;

            //上旬1~10，中旬11~20，下旬21~
            if (dayToday >= 21)
            {
                Console.WriteLine("今天是本月的下旬");
            }
            else if (dayToday <= 10)
            {
                Console.WriteLine("今天是本月的上旬");
            }
            else
            {
                Console.WriteLine("今天是本月的中旬");
            }
        }
    }
}
