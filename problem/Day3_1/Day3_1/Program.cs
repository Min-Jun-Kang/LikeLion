using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////문제 1.학점 평균 계산 프로그램
            ////설명:
            ////국어, 영어, 수학 점수를 사용자로부터 입력받아 총점과 평균을 구하는 프로그램을 작성하세요.

            ////요구사항:

            ////각 과목의 점수는 정수형으로 입력받습니다.

            //int count = 0;
            //console.write("국어 점수를 입력해주세요: ");
            //int ikor = int.parse(console.readline());
            //count += 1;
            //console.write("영어 점수를 입력해주세요: ");
            //int ieng = int.parse(console.readline());
            //count += 1;
            //console.write("수학 점수를 입력해주세요: ");
            //int imat = int.parse(console.readline());
            //count += 1;

            //Console.WriteLine();

            ////총점을 구한 후, 평균을 계산할 때 정수형 총점을 실수형으로 캐스팅하여 소수점까지 정확하게 계산합니다.
            //int sum = iKor + iEng + iMat;
            //double avg = (double)sum / count;
            //Console.WriteLine($"점수의 총합은 {sum}점 입니다.");
            ////----- 소수점 포맷 출력 예시
            ////double value = 1234.56;
            ////Console.WriteLine(value.ToString("F2")); // 출력: "1234.56"
            ////평균은 소수점 둘째 자리까지 출력하세요.
            //Console.WriteLine($"점수의 평균은 {avg.ToString("F2")}점 입니다.");

            //문제 2.비트 반전(~) 연산자 활용 프로그램
            //설명:
            //사용자로부터 정수를 입력받아, 해당 정수의 모든 비트를 반전(~)한 결과를 출력하는 프로그램을 작성하세요.

            //요구사항:

            ////정수를 입력받습니다.
            //Console.Write("정수를 입력해주세요: ");
            //int number = int.Parse(Console.ReadLine());
            ////String BiNumber = Convert.ToString(number, 2); 2진수로 표현
            //int RNumber = ~number;
            ////String BiRNumber = Convert.ToString(RNumber,2);

            //Console.WriteLine($"입력 하신 정수는 {number}");
            //Console.WriteLine($"입력 하신 정수의 비트 반전은 {RNumber}");

            ////비트 반전 연산자(~)를 이용하여 입력된 정수의 비트를 반전합니다.
            ////원래의 값과 비트 반전 후의 값을 함께 출력합니다.

            ////문제

            ////1단계
            ////가지고 있는 소지금을 입력하세요 : 
            ////0~100 무한의 대검 +1
            ////101~200 카타나 +2
            ////201~300 카타나 +3
            ////301~400 카타나 +4
            ////401~500 카타나 +5
            ////501~600 카타나 +6


            ////2단계
            ////캐릭터 이름 
            ////공격력 : 100 + 1
            //Console.Write("가지고 있는 소지금을 입력하세요 : ");
            //int money = int.Parse(Console.ReadLine());
            //string weapon = null;
            //int att = 0;
            //string name = "멋사검존";
            //if (money > 600)
            //{
            //    Console.WriteLine("전설의 검을 획득하셨습니다.");
            //    weapon = "전설의 검";
            //    att = 7;
            //}
            //else if (money <= 600 && money > 500)
            //{
            //    Console.WriteLine("유령검을 획득하셨습니다.");
            //    weapon = "유령의 검";
            //    att = 6;
            //}
            //else if (money <= 500 && money > 400)
            //{
            //    Console.WriteLine("엑스칼리버를 획득하셨습니다.");
            //    weapon = "엑스칼리버";
            //    att = 5;
            //}
            //else if (money <= 400 && money > 300)
            //{
            //    Console.WriteLine("집판검을 획득하셨습니다.");
            //    weapon = "집판검";
            //    att = 4;
            //}
            //else if (money <= 300 && money > 200)
            //{
            //    Console.WriteLine("진은검을 획득하셨습니다.");
            //    weapon = "진은검";
            //    att = 3;
            //}
            //else if (money <= 200 && money > 100)
            //{
            //    Console.WriteLine("카타나를 획득하셨습니다.");
            //    weapon = "카타나";
            //    att = 2;
            //}
            //else
            //{
            //    Console.WriteLine("무한의 대검을 획득하셨습니다.");
            //    weapon = "무한의 대검";
            //    att = 1;
            //}
            //Console.WriteLine($"캐릭터의 이름 : {name}");
            //Console.WriteLine($"캐릭터의 무기 : {weapon}");
            //Console.WriteLine($"캐릭터의 공격력 : 100 + {att}");

        }
    }
}
