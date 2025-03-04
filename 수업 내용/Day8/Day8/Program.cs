using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 종료");

            string path = Environment.GetEnvironmentVariable("PATH");
            Console.WriteLine($"PATH: {path}");

            Random random = new Random();

            int randomNumber = random.Next(1, 101); // 1부터 100까지
            Console.WriteLine("랜덤 숫자 : " + randomNumber);

            Stopwatch stopwatch = Stopwatch.StartNew();

            //실행코드
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1); //sleep은 어지간하면 안쓰는 것이 좋다. 게임에 영향주는 부분에서는
            }
            //0.001

            stopwatch.Stop();

            Console.WriteLine($"for 시간 {stopwatch.ElapsedMilliseconds}ms");

            string input = "Hello, my phone number is 010-1234-5678.";
            string pattern = @"\d{3}-\d{4}-\d{4}"; //전화번호 패턴


            bool isMatch = Regex.IsMatch(input, pattern); //Regex 문자열 검색 및 검사 수행
            Console.WriteLine($"전화번호가 존재하는가? {isMatch}");



            Environment.Exit(0); // 프로그램 종료 함수
        }
    }
}
