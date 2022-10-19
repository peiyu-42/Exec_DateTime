using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{//根據不同時間, 傳回不同問安方式
    internal class Program
    {
        static void Main(string[] args)
        {
            //現在的時間
            DateTime now = DateTime.Now;
            Console.WriteLine($"現在的時間 {now:yyyy / MM / dd HH:mm:ss}");

            //現在幾點
            int hours = now.Hour;

            //早安5~11，午安12~15，晚安16~22
            if (hours >= 0 && hours <= 12)
            {
                Console.WriteLine("早安");
            }
            else if (hours > 12 && hours <= 18)
            {
                Console.WriteLine("午安");
            }
            else 
            {
                Console.WriteLine("晚安");
            }

        }
    }
}
