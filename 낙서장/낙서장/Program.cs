using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 낙서장
{
    class Program
    {
        static void Main(string[] args)
        {
            //2025.02.26

            //split에 대해 알아보기

            //pharse.Split(??) -> ??를 기준으로 문자열의 배열로 나눈다.
            //string phrase = "The quick brown fox jumps over the lazy dog.";
            //string[] words = phrase.Split(' ');//띄어쓰기 기준으로 words 배열에 저장

            //foreach (var word in words)
            //{
            //    System.Console.WriteLine($"<{word}>");
            //}

            //자르는데 기준이 되는 ??은 배열에 포합되지 않는다.
            //string phrase = "The quick brown fox jumps over the lazy dog.";
            //string[] words = phrase.Split('a');

            //for (int i = 0; i < words.Length; i++)
            //{
            //    System.Console.WriteLine($"Index {i}: <{words[i]}>");
            //}

            ////연속된 구분 문자는 반환된 배열의 값으로 빈 문자열을 생성
            //string phrase = "The quick brown    fox     jumps over the lazy dog.";
            ////빈 칸이 4개가 동시에 있으니 처음 하나는 제외되고 나머지는 하나씩 빈 문자열로 인식 된다.
            //string[] words = phrase.Split(' ');

            //foreach (var word in words)
            //{
            //    System.Console.WriteLine($"<{word}>");
            //}

            ////다중 구분 문자를 사용할 수 있다.
            //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            //string text = "one\ttwo three:four,five six seven";
            //System.Console.WriteLine($"Original text: '{text}'");

            //string[] words = text.Split(delimiterChars); //사용한 흔적
            //System.Console.WriteLine($"{words.Length} words in text:");

            //foreach (var word in words)
            //{
            //    System.Console.WriteLine($"<{word}>");
            //}

            //2025.02.27
            //스레드에 알아보자
            //구조체(struct)에 대해 알아보자
            //클래스



        }
    }
}
