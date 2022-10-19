using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{//列出指定年份的每一個星期日
    internal class Program
    {
        static void Main(string[] args)
        {
            //指定年分
            Console.Write("請輸入西元年份:");
            string input=Console.ReadLine();

            //字串轉成數值
            int year = Convert.ToInt32(input);

            //那一年的第一天
            DateTime firstDay = new DateTime(year,1,1);
            DayOfWeek firstDayWeek = firstDay.DayOfWeek;//第一天是星期幾
            Console.WriteLine($"第一天:{firstDay: yyyy/MM/dd} {firstDayWeek}");

            //找到第一個星期日
            int value = (int)firstDayWeek;
            int addDay = 0; //到下一個星期一要加幾天
            for (int i = 1; i < 7; i++)
            {
                if (value == 0)
                {
                    break;
                }
                else
                {
                    value -= 1;
                }
                addDay = 7 - i;
            }
            Console.WriteLine($"到下一個星期日要加{ addDay}天");
            DateTime firstSunday = firstDay.AddDays(+addDay);//第一個星期日
            Console.WriteLine($"第一個星期日 {firstSunday: yyyy/MM/dd} {firstSunday.DayOfWeek}");
            
            //一年中所有的星期日
            DateTime everySunday= firstSunday;
            for (int k = 0; k < 366; k += 7)
            {
                everySunday = firstSunday.AddDays(k);

                if (everySunday.Year == year + 1) //如果日期累加到下一年就不要顯示
                {
                    break;
                }
                Console.WriteLine($"{everySunday: yyyy/MM/dd} {everySunday.DayOfWeek}");                
            }
        }
    }
}
