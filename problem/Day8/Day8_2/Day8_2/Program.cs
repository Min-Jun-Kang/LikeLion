using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_2
{
    //예외 처리
    //사용자에게 정수를 입력받고, 이를 int로 변환하는 프로그램을 작성하세요.
    //숫자로 변환할 수 없는 경우 FormatException을 처리하여 "올바른 숫자를 입력하세요!"라는 메시지를 출력하세요.
    //변환이 성공하면 입력한 숫자를 출력하세요.

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("정수를 입력해주세요 : ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine($"정수 변화에 성공하셨습니다. 출력 : {input}");
            }
            catch (FormatException ex)
            {

                Console.WriteLine("올바른 숫자를 입력하세요!");
            }


        }
    }
}
