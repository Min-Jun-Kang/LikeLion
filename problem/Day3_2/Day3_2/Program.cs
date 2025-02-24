using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("가지고 있는 소지금을 입력하세요 : ");
            int money = int.Parse(Console.ReadLine());
            string weapon = null;
            int att = 0;
            string name = "멋사검존";
            if (money > 600)
            {
                Console.WriteLine("전설의 검을 획득하셨습니다.");
                weapon = "전설의 검";
                att = 7;
            }
            else if (money <= 600 && money > 500) 
            {
                Console.WriteLine("유령검을 획득하셨습니다.");
                weapon = "유령의 검";
                att = 6;
            }
            else if (money <= 500 && money > 400)
            {
                Console.WriteLine("엑스칼리버를 획득하셨습니다.");
                weapon = "엑스칼리버";
                att = 5;
            }
            else if (money <= 400 && money > 300)
            {
                Console.WriteLine("집판검을 획득하셨습니다.");
                weapon = "집판검";
                att = 4;
            }
            else if (money <= 300 && money > 200)
            {
                Console.WriteLine("진은검을 획득하셨습니다.");
                weapon = "진은검";
                att = 3;
            }
            else if (money <= 200 && money > 100)
            {
                Console.WriteLine("카타나를 획득하셨습니다.");
                weapon = "카타나";
                att = 2;
            }
            else
            {
                Console.WriteLine("무한의 대검을 획득하셨습니다.");
                weapon = "무한의 대검";
                att = 1;
            }
            Console.WriteLine($"캐릭터의 이름 : {name}");
            Console.WriteLine($"캐릭터의 무기 : {weapon}");
            Console.WriteLine($"캐릭터의 공격력 : 100 + {att}");


        }
    }
}
