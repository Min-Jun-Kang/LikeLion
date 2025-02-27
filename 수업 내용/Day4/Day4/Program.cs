using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch문

            //int day = 1;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    default:
            //        Console.WriteLine("주말입니다.");
            //        break;
            //}

            ////switch문 연습

            //Console.WriteLine("캐릭터를 선택해주세요!");
            //Console.WriteLine("1.검사 2.마법사 3.도적");
            //Console.WriteLine();
            //Console.Write("원하시는 캐릭터의 번호를 입력해주세요 : ");
            //int choose = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //switch (choose)
            //{
            //    case 1:
            //        Console.WriteLine("검사를 선택하셨습니다.");
            //        Console.WriteLine("공격력 : 100");
            //        Console.WriteLine("방어력 : 90");
            //        break;
            //    case 2:
            //        Console.WriteLine("마법사를 선택하셨습니다.");
            //        Console.WriteLine("공격력 : 110");
            //        Console.WriteLine("방어력 : 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("도적을 선택하셨습니다.");
            //        Console.WriteLine("공격력 : 115");
            //        Console.WriteLine("방어력 : 70");
            //        break;
            //    default:
            //        Console.WriteLine("번호를 다시 입력해주세요.");
            //        break;
            //}

            ////반복문
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("숫자 : " + i);
            //}

            ////무한반복
            //for (; ; )
            //{
            //    Console.WriteLine("중요한건 꺽이지 않는 마음");
            //}

            //for문 활용하기
            //0~9까지 출력하기

            //for (int i = 0; i < 10; i++) {
            //    Console.Write(i+" ");
            //}

            //1부터 10까지의 합 구하기
            //int sum = 0;
            //for (int i = 1; i < 11; i++) 
            //{
            //    sum = sum + i;
            //    Console.WriteLine($"i의 값 : {i}");
            //    Console.WriteLine($"sum의 값 : {sum}");
            //}

            //whiile문

            //int count = 1; //초기화

            //while (count <= 5) //조건식
            //{
            //    Console.WriteLine("Count : " + count);

            //    count++; //증가,감소

            //    if (count == 3)
            //    {
            //        Console.WriteLine("3일때 반복문 탈출");
            //        break;
            //    }

            //}

            //Console.WriteLine("Count : " + count);

            ////랜덤
            //Random rand = new Random(); //Random 객체를 생성한다.

            ////0이상 10 미만의 랜덤 정수 생성
            //int randomInRange = 0; //double을 이용해서 실수도 생성 가능하다.

            //for (int i = 0; i < 100; i++)
            //{
            //    randomInRange = rand.Next(5, 15); //a이상 b미만 까지
            //    Console.WriteLine("5부터 14까지: " + randomInRange);

            //}

            //랜덤 이용한 예제

            //대장장이 키우기 (도끼 뽑기)

            //도끼등급 SSS  10%
            //도끼등급 SS   40%
            //도끼등급 S    50%

            //Random rand = new Random(); //랜덤은 따로 선언해야 한다. Random 클래스 불러오기

            //int randominRange = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine($"{i + 1}번째 뽑기 결과!!");
            //    randominRange = rand.Next(1, 101);
            //    //Console.WriteLine($"랜덤의 값 : {randominRange}");

            //    if (randominRange <= 10)
            //    {
            //        Console.WriteLine("SSS등급의 도끼가 탄생했습니다.");
            //    }
            //    else if (randominRange > 11 && randominRange <= 50)
            //    {
            //        Console.WriteLine("SS등급의 도끼가 탄생했습니다.");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("S등급의 도끼가 탄생했습니다.");
            //    }
            //    Thread.Sleep(500); //0.5초의 간격 두기
            //}

            ////do while
            ////1회 무조건 실행하고 while문과 같이 조건진행

            //int x = 5;

            //do
            //{
            //    Console.WriteLine("최소 한번은 실행됩니다.");
            //    x--;
            //} while (x > 0);

            //break 문
            //반복문을 탈출할 수 있습니다.

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break; //조건문을 만족하지 않았어도 이때 반복문이 끝나버린다.
            //    }

            //    Console.WriteLine(i);
            //}

            //continue
            //패싱 느낌? 식을 돌다가 만나면 무시하고 다음 반복문으로 넘어간다.

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i); //홀수만 출력
            //}

            //goto 

            //int n = 1;

            //start:

            //if(n <=5)
            //{
            //    Console.WriteLine(n);
            //    n++;

            //    goto start; //레이블로 이동
            //} 

        }
    }
}
