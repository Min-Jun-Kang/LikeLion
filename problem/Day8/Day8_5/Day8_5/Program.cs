
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_5
{
    class Program
    {
    //    LINQ 활용
    //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 배열이 주어질 때,
    //    LINQ를 사용하여 짝수만 필터링하고 출력하세요.
    //    LINQ를 사용하여 모든 숫자의 합을 구하고 출력하세요.
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.Write("짝수 : ");
            foreach (var num in evenNumbers)
            {
                Console.Write(num +" ");
            }
            Console.WriteLine();

            var sumNumbers = numbers.Sum();

            Console.WriteLine($"모든 숫자의 합 : {sumNumbers}");


        }
    }
}
