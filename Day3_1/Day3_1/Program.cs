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
            ////비교 연산자
            //int x = 5, y = 10;

            //Console.WriteLine(x == y);  // false
            //Console.WriteLine(x != y);  // true
            //Console.WriteLine(x < y);   // true
            //Console.WriteLine(x > y);   // false
            //Console.WriteLine(x >= y);  // false
            //Console.WriteLine(x <= y);  //true

            ////논리연산자
            ///
            //bool a = true, b = false;
            //Console.WriteLine(a && b); //false
            ////AND 연산자, 둘 다 true 일 경우에만 true 출력, 곱하기 개념(true = 1, false =0)
            //Console.WriteLine(a || b); //true
            ////OR 연산자, 둘 다 false 일 경우에만 false 출력, 더하기 개념
            //Console.WriteLine(!a); //false
            ////NOT 연산자, 논리 값을 true -> false, false -> true로 바꿈

            ////비트연산자
            //int x = 5; // 0101
            //int y = 3; // 0011 

            //Console.WriteLine(x & y); //AND : 1 (0001) 양 쪽다 1인 곳만 1로 계산
            //Console.WriteLine(x | y); //OR : 7 (0111) 한 쪽만 1이여도 1로 계산
            //Console.WriteLine(x ^ y); //XOR :6   (0110) 양 쪽다 같은 곳만 1로 계산
            //Console.WriteLine(~x);    //NOT : -6  (1010)
            //Console.WriteLine(~y);

            //int value = 4; // 0100

            //Console.WriteLine(value << 1); //왼쪽 이동 : 8 (1000)
            //Console.WriteLine(value >> 1); //왼쪽 이동 : 2 (0010)

            ////삼항 연산자

            //int a = 10, b = 20;

            //int max;

            //max = (a < b) ? a : b; //삼항 연산자
            ////(비교) ? 참 : 거짓;
            //// (a > b) ? a : b 에서 ? 기준으로 앞을 비교 -> 앞의 논리가 true인 경우 a를 출력, false인 경우 b를 출력
            //Console.WriteLine(max);

            ////응용
            //int key = 2;
            //String str;
            //str = (key == 1) ? "문을 열었습니다.": "문을 못 열었습니다.";

            //Console.WriteLine(str);

            //// 사칙연산 우선 순위가 적용된다.

            //int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5; //괄호 우선순위 먼저계산

            //Console.WriteLine(adjustedResult);

            ////조건문

            //int score = 89;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점"); // if문 뒤에 있는 조건이 참인 경우
            //}
            //else
            //{
            //    Console.WriteLine("B 학점"); // 거짓인 경우
            //}

            //string GameID = "멋사검존";

            //if (GameID == "멋사검존") //(string.Compare(GameID,"멋사검존" ) ==0)
            //{
            //    Console.WriteLine("아이디가 일치합니다.");
            //}
            //else 
            //{
            //    Console.WriteLine("아이디가 일치하지 않습니다.");
            //}

            ////else if문
            //int score = 60;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F 학점");
            //}


        }
    }
}
