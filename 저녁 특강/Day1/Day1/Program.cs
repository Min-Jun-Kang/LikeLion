using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    //2025/03/04
    class Program
    {
        static void Main(string[] args)
        {
            //조건문
            ////switch 문
            ////점수등급 (A,B,C,D)에 따라 메시지를 출력하세요
            ////A=최고, B=좋음, C=보통, D=탈락

            //string input = (Console.ReadLine());
            //switch (input)
            //{
            //    case "A":
            //        Console.WriteLine("최고");
            //        break;
            //    case "B":
            //        Console.WriteLine("좋음");
            //        break;
            //    case "C":
            //        Console.WriteLine("보통");
            //        break;
            //    case "D":
            //        Console.WriteLine("탈락");
            //        break;
            //}

            //계절
            //12~2 겨울
            //3~5 봄
            //6~8 여름
            //9~11 가을
            //다른 숫자가 입력되면 => 잘 못 입력되었습니다.

            //int month = int.Parse(Console.ReadLine());

            //if (month >= 3 && month <= 5)
            //    Console.WriteLine("봄");
            //else if (month > 5 && month < 9)
            //    Console.WriteLine("여름");
            //else if (month > 8 && month < 12)
            //    Console.WriteLine("가을");
            //else if (month == 12 || (month < 3 && month > 0))
            //    Console.WriteLine("겨울");
            //else
            //    Console.WriteLine("잘못 입력되었습니다.");

            //switch문으로도 작성 가능
            //switch (month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("겨울"); break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("봄"); break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("여름"); break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("여름"); break;
            //    default:
            //        Console.WriteLine("잘 못 입력되었습니다."); break;
            //}

            ////반복문
            ////1부터 10까지의 합을 구하세요.
            //int sum = 0;
            //for (int i = 1; i <= 10; i++) 
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //숫자를 입력받아 입력받은 숫자의 구구단 단수를 출력하세요.
            //예 : 숫자 2를 입력하면 2 x 1 = 2 ...

            //int input = int.Parse(Console.ReadLine());

            //for (int i = 1; i < 10; i++) 
            //{
            //    Console.WriteLine($"{input} x {i} = {input * i}");
            //}

            //*찍기
            //*
            //**
            //***
            //****
            //이중 for문인 경우
            //for (int i = 1; i < 5; i++) 
            //{
            //    for (int j = 1; j <= i; j++) 
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////단일 for문인 경우
            //string star = "*";
            //for (int i = 0; i < 4; i ++) 
            //{
            //    Console.WriteLine(star);
            //    star += "*";
            //}

        }
    }
}
