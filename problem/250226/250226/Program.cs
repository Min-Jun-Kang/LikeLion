using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250226
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 문제1: 크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.
            //Console.WriteLine("배열 문제 1번");
            //int[] Array = new int[5];
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    Array[i] = 10 * (i + 1);
            //}
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    Console.Write(Array[i] + " ");
            //}
            //// 문제: 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.
            //Console.WriteLine("배열 문제 2번");
            //int[] Array2 = new int[5];
            //int input = 0;
            //int sum = 0;
            //for (int i = 0; i < Array2.Length; i++)
            //{
            //    Console.Write("정수를 입력하세요 : ");
            //    input = int.Parse(Console.ReadLine());
            //    Array2[i] = input;
            //}
            //for (int i = 0; i < Array2.Length; i++)
            //{
            //    sum += Array2[i];
            //}
            //Console.WriteLine($"총합 : {sum}");
            //// 문제: 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.
            //Console.WriteLine("배열 문제 3번");
            //int[] Array3 = new int[] { 3, 8, 15, 6, 2 };
            //int max = 0;
            //for (int i = 0; i < Array3.Length; i++)
            //{
            //    if (Array3[i] > max)
            //    {
            //        max = Array3[i];
            //    }
            //}
            //Console.WriteLine($"최대 값은 {max}입니다.");
            // 문제: 1~10까지 출력하기(반복문 이용)
            //Console.WriteLine("반복문 문제 1번");
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //// 문제 : while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.
            //Console.WriteLine("반복문 문제 2번");
            //int i = 1;
            //while (i < 11)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    i++;
            //}
            ////문제 : foreach문을 사용하여 배열 {1,2,3,4,5}의 요소를 출력하세요.
            //Console.WriteLine("반복문 문제 3번");
            //int[] array = new int[] { 1, 2, 3, 4, 5, };

            //foreach (int number in array)
            //{
            //    Console.Write(number + " ");
            //}
            ////문제 : 두 수의 합을 구하는 함수
            //Console.WriteLine("함수 문제 1번");
            //Console.Write("정수를 입력하세요 : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("정수를 입력하세요 : ");
            //int num2 = int.Parse(Console.ReadLine());

            //int result = Add(num1,num2);
            //Console.WriteLine($"{num1}과{num2}의 합 : {result}");

            ////문제 문자열을 입력받아 길이를 변환하는 함수를 작성하세요.

            //Console.Write("문자열을 입력하세요 : ");
            //String str = Console.ReadLine();
            //int length = Length(str);
            //Console.WriteLine($"문자열 길이 : {length}");

            //문제 : 세 개의 정수를 입력 받아 가장 큰 값을 반환하는 함수를 작성하세요.
            Console.Write("첫 번째 정수를 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수를 입력하세요 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("세 번째 정수를 입력하세요 : ");
            int num3 = int.Parse(Console.ReadLine());

            int maxNum = MaxNumber(num1, num2, num3);

            Console.WriteLine($"가장 큰 수 : {maxNum}");


        }
        static int MaxNumber(int num1, int num2, int num3) 
        {
            int max = num1;
            if (num2 > max)
                max = num2;
            if (num3 > max)
                max = num3;

            return max;
        }



        static int Length(String str) 
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++) 
            {
                count++;
            }
            return count;
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }

}
