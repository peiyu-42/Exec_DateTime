using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{//計算圖書下個月歸還時間
    internal class Program
    {
        static void Main(string[] args)
        {
            //現在的日期
            DateTime today = DateTime.Today;           

            //一個月後歸還
            var afterAMouth = today.AddMonths(1);

            Console.WriteLine($"今天的日期 {today:yyyy/MM/dd}");
            Console.WriteLine($"歸還的日期 {afterAMouth:yyyy/MM/dd}");

        }
    }
}
