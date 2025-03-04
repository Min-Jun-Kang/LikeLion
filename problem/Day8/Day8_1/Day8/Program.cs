using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day8
{
    //1번 클래스와 상속
    //Warrior 클래스를 만들고 Name과 Score 속성을 추가하세요.
    //Warrior Strength 속성을 추가하세요.
    //Main 메서드에서 Warrior 객체를 생성하고, Name, Score, Strength 값을 설정한 후 출력하세요.

    class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Strength { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.Name = "LikeLion";
            warrior.Score = 0;
            warrior.Strength = 100;

            Console.WriteLine($"이 름 : {warrior.Name}");
            Console.WriteLine($"점 수 : {warrior.Score}");
            Console.WriteLine($"힘 : {warrior.Strength}");

        }
    }
}
