using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_4
{
    //문자열 처리
    //사용자로부터 "Hello, C# World!" 같은 문자열을 입력받아, 다음을 수행하세요.
    //전체 문자열을 대문자로 변환
    //"C#"을 "CSharp"으로 변경
    //문자열의 길이 출력
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자열을 입력하세요 : ");
            string input = Console.ReadLine();
            string UpInput = input.ToUpper();
            string CSharpInput = input.Replace("C#", "CSharp");

            Console.WriteLine($"전체 문자열 대문자 변환 : {UpInput}");
            Console.WriteLine($"C# -> CSharp으로 변환 : {CSharpInput}");
            Console.WriteLine($"문자열의 길이 : {input.Length}");

        }
    }
}
