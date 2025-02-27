using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        //1.매개변수도 반환값도 없는 함수
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요");

        }
        //2.매개변수만 있는 함수
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        //3.반환값만 있는 함수
        static int GetNumber()
        {

            return 42;
        }

        //4.매개변수와 반환값이 있는 함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        //5.기본값을 가진 매개변수 (디폴트 매개변수)
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        //6.함수 오버로딩(Overloading)

        /// <summary>
        /// 두수를 곱하는 함수
        /// </summary>
        /// <param name="a">int,double 오버로딩해놈</param>
        /// <param name="b">int,double 오버로딩해놈</param>
        /// <returns></returns>
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        //7.out 키워드 (여러 값을 반환할때)
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;

            remainder = a % b;

        }

        //8.ref 키워드 (값을 참조하여 수정) 포인터 개념
        static void Increase(ref int num)
        {
            num += 10;
        }

        //9.params 키워드 (가변 매개변수)
        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            return total;

        }

        //10.재귀 함수(자기 자신을 호출)
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;   //출력겸 탈출

            return n * Factorial(n - 1); //자기 자신을 호출하는 부분
        }


        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            //PrintHello(); //출력
            //PrintMessage("반갑습니다.");
            ////로컬변수
            //int num = GetNumber();
            //Console.WriteLine(num);

            //Console.WriteLine(Add(3, 5));

            //Greet(); //디폴트 값을 출력
            //Greet("철수"); //내가 입력한 값을 출력

            ////메인
            //int q, r;
            //Divide(10, 3, out q, out r);

            //Console.WriteLine($"몫: {q}, 나머지 : {r}"); //출력 :몫: 3, 나머지: 1

            //int value = 5;

            //Increase(ref value);

            //Console.WriteLine(value);

            //Console.WriteLine(Sum(1, 2, 3));   //출력 6

            //Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            //Factorial(5) = 5 * 4 * 3 * 2 * 1 = 120
            Console.WriteLine(Factorial(5));

        }
    }
}
