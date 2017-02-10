using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_exercise
{
    class Program
    {
        enum Week : byte
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入星期:");
            while (true)
            {
                Week week = (Week)byte.Parse(Console.ReadLine());
                switch (week)
                {
                    case Week.Sunday:
                        Console.WriteLine("星期日特價菜: 蔥爆牛肉");
                        break;
                    case Week.Monday:
                        Console.WriteLine("星期一特價菜: 啤酒鴨");
                        break;
                    case Week.Tuesday:
                        Console.WriteLine("星期二特價菜: 紅燒肉");
                        break;
                    case Week.Wednesday:
                        Console.WriteLine("星期三特價菜: 番茄炒蛋");
                        break;
                    case Week.Thursday:
                        Console.WriteLine("星期四特價菜: 紅酒燉牛肉");
                        break;
                    case Week.Friday:
                        Console.WriteLine("星期五特價菜: 宮保雞丁");
                        break;
                    case Week.Saturday:
                        Console.WriteLine("星期六特價菜: 炸豬排");
                        break;
                    default:
                        Console.WriteLine("NO NO NO No");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
