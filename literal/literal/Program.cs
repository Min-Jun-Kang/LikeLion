using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace literal
{
    class Program
    {
        static void Main(string[] args)
        {
            //리터럴 : 코드에서 고정된 값을 의미한다.
            int number = 10; //정수형 리터럴 (int형 변수 number를 생성하면서 10이라는 값을 담는다.)
            double pi = 3.14; //실수형 리터럴
            char letter = 'A'; //문자형 리터럴
            string name = "Alice"; //문자열 리터럴

            //Console.WriteLine(number); // 10 출력
            //Console.WriteLine(pi); // 3.14 출력
            //Console.WriteLine(letter); // A 출력
            //Console.WriteLine(name); // Alice 출력

            int hp = 100;
            double att = 56.7;
            char grade = 'S';
            string name2 = "Lion";
            Console.WriteLine("캐릭터 이름 :" + name2);
            Console.WriteLine("캐릭터 체력 : " + hp);
            Console.WriteLine("캐릭터 등급 : " + grade);
            Console.WriteLine("캐릭터 공격력 : " + att);

        }
    }
}
