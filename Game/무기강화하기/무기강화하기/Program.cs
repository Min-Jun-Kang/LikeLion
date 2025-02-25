using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 무기강화하기
{
    class Program
    {
        static void Main(string[] args)
        {
            //랜덤 함수
            Random rand = new Random();

            //콘솔 크기 설정
            Console.SetWindowSize(80, 25);
            //콘솔 버퍼 설정
            Console.SetBufferSize(80, 25);
            //커서 사라지게 하기
            Console.CursorVisible = false;

            Console.Clear();
            //시작 화면
            for (int i = 0; i < 22; i++) 
            {
                Console.SetCursorPosition(0, i);
                if (i == 0)
                {
                    Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                    Thread.Sleep(500);
                }
                else if (i == 10)
                {
                    Console.Write("┃                               무기 강화하기                                 ┃");
                    Thread.Sleep(500);
                }
                else if (i == 21)
                {
                    Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                    Thread.Sleep(1000);

                }
                else
                { 
                    Console.Write("┃                                                                             ┃");
                    Thread.Sleep(500);
                }
            }
            Console.SetCursorPosition(20,17);
            Console.Write("게임을 시작하려면 엔터 키를 눌러주세요.");
            Console.ReadLine();
            Console.Clear();

            //게임 화면
            string weapon_name = "녹슨 검";
            int enhance = 1;
            //int damage = 10;

            int choose;
            while (true) 
            {
                if (enhance == 10)
                {
                    enhance = 1;
                    weapon_name = "엑스칼리버";
                }
                Console.WriteLine("한 장비에서 10단계가 되면 다음 무기로 업그레이드 됩니다.");
                Console.WriteLine("강화 실패 시 수치 하락은 없지만 파괴될 확률은 있습니다.");
                Console.WriteLine("장비 파괴 시 녹슨 검 1단계 부터 다시 시작합니다.");
                Console.WriteLine();
                Console.WriteLine($"현재 상태 : +{enhance} {weapon_name}");
                Console.WriteLine();
                if (enhance ==10 && weapon_name == "엑스칼리버") 
                {
                    Console.WriteLine("다음 단계의 무기가 아직 준비되어있지 않습니다.");
                    Console.WriteLine();
                    Console.WriteLine("다음 패치에 추가될 예정입니다.");
                    Console.WriteLine();
                    Console.WriteLine("즐겨주셔서 감사합니다!!!");
                    Environment.Exit(1);
                }
                Console.WriteLine("1. 강화 하기");
                Console.WriteLine("2. 게임 종료");
                Console.WriteLine();
                Console.Write("번호를 입력해주세요 : ");
                choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    int rnd = rand.Next(1, 101); //1~100까지 정수 생성
                    Console.Clear();
                    Console.WriteLine("강화를 시작합니다...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.SetCursorPosition(30, 10);
                    Console.WriteLine("강화를 진행중입니다...");
                    for (int i = 30; i < 48; i++) 
                    {
                        Console.SetCursorPosition(i, 15);
                        Console.Write("■■");
                        Thread.Sleep(100);
                    }
                    Console.Clear();

                    if (enhance <= 5) //파괴 확률 1%, 강화 확률 50%
                    {
                        if (rnd == 1)
                        {
                            Console.WriteLine("장비가 파괴되었습니다!!!!");
                            enhance = 1;
                            Thread.Sleep(2000);
                        }
                        else if (rnd <= 51)
                        {
                            Console.WriteLine("강화에 성공하셨습니다!!!!");
                            enhance++;
                            Thread.Sleep(2000);
                        }
                        else 
                        {
                            Console.WriteLine("강화에 실패하셨습니다!!!!");
                            Thread.Sleep(2000);
                        }
                    }
                    else if (enhance <= 7) //파괴 확률 5% 강화 확률 40%
                    {
                        if (rnd <= 5)
                        {
                            Console.WriteLine("장비가 파괴되었습니다!!!!");
                            enhance = 1;
                            Thread.Sleep(2000);
                        }
                        else if (rnd <= 45)
                        {
                            Console.WriteLine("강화에 성공하셨습니다!!!!");
                            enhance++;
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("강화에 실패하셨습니다!!!!");
                            Thread.Sleep(2000);
                        }

                    }
                    else if (enhance <= 9) //파괴 확률 10% 강화 확률 30%
                    {
                        if (rnd <= 10)
                        {
                            Console.WriteLine("장비가 파괴되었습니다!!!!");
                            enhance = 1;
                            Thread.Sleep(2000);
                        }
                        else if (rnd <= 40)
                        {
                            Console.WriteLine("강화에 성공하셨습니다!!!!");
                            enhance++;
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("강화에 실패하셨습니다!!!!");
                            Thread.Sleep(2000);
                        }
                    }
                    Console.Clear();
                }
                else if (choose == 2)
                {
                    Console.WriteLine("게임을 죵로합니다.");
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("번호를 다시 입력해주시길 바랍니다.");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }



            




        }
    }
}
