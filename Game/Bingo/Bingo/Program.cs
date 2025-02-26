using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            //////스왑 개념
            ////int a = 10;
            ////int b = 20;
            ////int t = 0;

            ////t = a;
            ////a = b;
            ////b = t;

            ////Console.Write("a : " + a + " b : " + b);

            //int[] iArray = new int[25];

            //for (int i = 0; i < 25; i++)
            //{
            //    iArray[i] = i + 1;
            //}

            //////1차원의 배열을 이중포문으로 출력하는 법
            ////for (int i = 0; i < 5; i++) 
            ////{
            ////    for (int j = 0; j < 5; j++)
            ////    {
            ////        //Console.WriteLine(iArray[i*5+j].ToString("D2"));//D2는 두 자리수로 표현
            ////        Console.Write(iArray[i * 5 + j].ToString("D2")+" ");
            ////    }
            ////    Console.WriteLine();// 5개 찍고 줄 바꿈
            ////}

            ////셔플
            //Random rand = new Random();
            //for (int i = 0; i < 100; i++) //시행을 최대한 해서 최대한 섞이게 하기 위함
            //{
            //    int iA = rand.Next(0, 25);
            //    int iB = rand.Next(0, 25);
            //    int iT = 0;

            //    //셔플
            //    iT = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iT;
            //}

            //int input = 0;
            //int iBingo = 0;
            //int iCount = 0;

            //while (true) 
            //{

            //    Console.Clear();

            //    //빙고판
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0) //0일경우 체크
            //            {
            //                Console.Write(" * ");
            //            }
            //            else 
            //            { 
            //                //Console.WriteLine(iArray[i*5+j].ToString("D2"));//D2는 두 자리수로 표현
            //                Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //            }
            //        }
            //        Console.WriteLine();// 5개 찍고 줄 바꿈
            //    }
            //    //입력
            //    Console.WriteLine();
            //    Console.WriteLine($"빙고 숫자 : {iBingo}");
            //    //빙고판 종료
            //    if (iBingo >= 5)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("빙고 성공!!");
            //        break;
            //    }
            //    Console.WriteLine("1~25 사이의 숫자를 입력하세요: ");
            //    input = int.Parse(Console.ReadLine());
            //    iBingo = 0; //한 번 빙고 였던 곳을 중복해서 세지 않게하기 위함

            //    for (int i = 0; i < 25; i++) 
            //    {
            //        if (iArray[i] == input) 
            //        {
            //            iArray[i] = 0;
            //            break;
            //        }
            //    }
            //    //빙고처리
            //    //가로 세로 대각선 체크

            //    //가로
            //    for (int i = 0; i < 5; i ++) 
            //    {
            //        for (int j = 0; j < 5; j++) 
            //        {
            //            if (iArray[i * 5 + j] == 0) 
            //            {
            //                ++iCount;
            //            }
            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }

            //    //세로
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[j * 5 + i] == 0)
            //            {
            //                ++iCount;
            //            }
            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }
            //    //대각선 오른쪽체크
            //    //4의 배수를 체크하면 된다.
            //    for (int i = 1; i < 6; i++) 
            //    {
            //        if (iArray[i * 4] == 0) 
            //        {
            //            ++iCount;
            //        }
            //        if (iCount == 5) 
            //        {
            //            ++iBingo;
            //        }
            //    }
            //    iCount = 0;

            //    //대각선 왼쪽체크
            //    //6의 배수를 체크하면 된다.
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 6] == 0)
            //        {
            //            ++iCount;
            //        }
            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //        }
            //    }
            //    iCount = 0;

            //}


            int[,] board = new int[5, 5]; //5x5 빙고판
            bool[,] marked = new bool[5, 5]; //선택된 숫자 체크

            int bingoCount = 0;

            Random random = new Random();

            //빙고판 초기화
            int[] numbers = new int[25];

            for (int i = 0; i < 25; i++)
                numbers[i] = i + 1;

            //랜덤 섞기(Fisher-Yates Shuffle)
            for (int i = 0; i < 100; i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);

                // C#의 튜플(Tuple) 문법을 활용하여 두 변수의 값을 교환(Swap)하는 방법
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);

            }


            //2차원 배열로 변환
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }

            //게임시작
            while (bingoCount < 5)
            {
                Console.Clear();

                //빙고판 출력
                Console.WriteLine("현재 빙고판");


                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j],2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.Write("숫자를 입력하세요 (1~25) : ");
                int number = int.Parse(Console.ReadLine());

                bool found = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (board[i, j] == number)
                        {
                            marked[i, j] = true; //숫자를 X로 변경
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        break;
                }

                //빙고 개수 체크
                bingoCount = 0;

                //가로체크
                for (int i = 0; i < 5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                        if (!marked[i, j]) rowBingo = false;

                    if (rowBingo) bingoCount++;
                }


                //세로체크
                for (int j = 0; j < 5; j++)
                {
                    bool colBingo = true;

                    for (int i = 0; i < 5; i++)
                        if (!marked[i, j]) colBingo = false;

                    if (colBingo) bingoCount++;
                }


                //대각선 체크 (왼쪽위 ->오른쪽 아래)

                bool diag1Bingo = true;

                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, i])
                        diag1Bingo = false;
                }
                if (diag1Bingo)
                    bingoCount++;


                //대각선 오른쪽위 ->왼쪽아래
                bool diag2Bingo = true;

                for (int i = 0; i < 5; i++)
                    if (!marked[i, 4 - i]) diag2Bingo = false;


                if (diag2Bingo) bingoCount++;

            }

            Console.WriteLine("빙고 5개 완성! 게임종료");



        }

    }
}
