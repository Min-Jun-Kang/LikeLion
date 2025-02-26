using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day5_2
{
    class Program
    {
        //메모리 영역
        //스택
        //힙
        //정적 메모리(static memory)
        //main 함수에도 static이 붙어 있듯이 함수 선언할 때 static을 앞에 붙여야한다.

        //함수

        //1단계 함수
        //반환형 함수이름 (매개변수)
        //{
        //}

        //1단계 기본형
        static void Loading()
        {
            Console.WriteLine("로딩화면");
        }

        //2단계 함수
        //입력
        static void AttackFunction(int Attack) //main 함수 안에 있는 Attack과는 다른 변수임
        {
            Console.WriteLine("공격력은 : " + Attack);
        }
        //3단계 함수
        //출력
        static int BaseAttack() //return으로 보낼 때는 함수에 그에 맞는 타입을 적어야한다.
        {
            //기본 공격력 10
            int attack = 10;

            return attack; //출력
        }

        static int Add(int num1, int num2) 
        {
            int sum = num1 + num2;
            return sum;
        }

        static void Main(string[] args)
        {
            //1단계 활용
            //Loading(); //다른 함수에서 실행 시키는 법
            //Loading();
            //Loading();

            //2단계 활용
            //int Attack = 0;
            //Console.WriteLine("캐릭터의 공격력을 입력 : ");
            //Attack = int.Parse(Console.ReadLine());

            //AttackFunction(Attack); //여기서 받아져서 AttackFunction안으로 들어간다.

            ////3단계 활용
            //int Attack = 0;
            //int BAttack;
            //BAttack = BaseAttack();

            //Console.WriteLine("캐릭터의 공격력을 입력 : ");
            //Attack = int.Parse(Console.ReadLine());

            //AttackFunction(BAttack + Attack);

            //함수 예제
            //int result = Add(10, 20); //입력받는 함수 필요
            //Console.WriteLine($"10 + 20 = {result}"); //출력받는 함수 필요
            ////한 함수에서 둘 다 처리 가능

            ////for each문
            //string[] fruits = { "사과", "바나나", "체리" };

            ////반복문
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

        }
    }
}
