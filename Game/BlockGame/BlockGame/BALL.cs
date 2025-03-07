using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
배열을 이용한 공 움직임도 유한 상태 기계(FSM)로 볼 수 있습니다.
공의 움직임은 방향(Up, Down, Left, Right)에 따라 상태가 변경되므로, 
이를 상태(State)와 전이(Transition) 개념으로 관리할 수 있습니다.

공 움직임을 FSM으로 정의하기
(1) 상태(State) 정의
공은 현재 위치(x, y)와 방향(Direction)을 가집니다.
FSM에서 공의 방향을 상태로 설정할 수 있습니다.

csharp
복사
편집
enum Direction
{
    Up,
    Down,
    Left,
    Right
}
*/



namespace BlockGame
{
    //움직일 bar 필요
    //벽돌 block 필요
    public class BALL
    {
        BALLDATA m_tBall = new BALLDATA(); //볼 데이터 생성

        //C#공의 방향 배열 정의
        //int [충돌벽,들어온방향] = 나가는방향
        int[,] g_WallCollision = new int[4, 6]
        {
            {  3,  2, -1, -1, -1, 4 },
            { -1, -1, -1, -1,  2, 1 },
            { -1,  5,  4, -1, -1,-1 },
            { -1, -1,  1,  0,  5,-1 }
        };

        Bar m_pBar;

        //Bar 클래스 가져오기
        public void SetBar(Bar bar) { m_pBar = bar; }


        public void ScreenWall() 
        {
            Program.gotoxy(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Program.gotoxy(0, 1);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 2);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 3);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 4);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 5);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 6);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 7);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 8);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 9);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 10);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 11);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 12);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 13);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 14);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 15);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 16);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 17);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 18);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 19);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 20);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 21);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 22);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 23);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }

        public BALLDATA GetBall() { return m_tBall; }

        public void SetX(int x) { m_tBall.X += x; }
        public void SetY(int y) { m_tBall.Y += y; }
        public void setBall(BALLDATA tBall) { m_tBall = tBall; }
        public void setReady(int Ready) { m_tBall.Ready = Ready; }

        public int Collision(int x, int y)
        {
            //벽 충돌
            if (y == 0) //위쪽 벽
            {
                m_tBall.Direct = g_WallCollision[0, m_tBall.Direct]; //방향에 따른 배열에서 값 가져오기
                return 1; //공의 방향이 바뀌면 1리턴
            }
            if (x == 1) //왼쪽 벽
            {
                m_tBall.Direct = g_WallCollision[1, m_tBall.Direct]; //방향에 따른 배열에서 값 가져오기
                return 1;
            }
            if (x == 77) //오른쪽 벽
            {
                m_tBall.Direct = g_WallCollision[2, m_tBall.Direct]; //방향에 따른 배열에서 값 가져오기
                return 1;
            }
            if (y == 23) //아래쪽 벽
            {
                m_tBall.Direct = g_WallCollision[3, m_tBall.Direct]; //방향에 따른 배열에서 값 가져오기
                return 1;
            }
            //Bar충돌처리
            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
                y == (m_pBar.m_tBar.nY)) //바 위 충돌
            {
                if (m_tBall.Direct == 1)
                    m_tBall.Direct = 2;
                else if (m_tBall.Direct == 2)
                    m_tBall.Direct = 1;
                else if (m_tBall.Direct == 5)
                    m_tBall.Direct = 4;
                else if (m_tBall.Direct == 4)
                    m_tBall.Direct = 5;

                return 1; //방향이 바뀐다.
            }

            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
              y == (m_pBar.m_tBar.nY + 1)) //바 아래 충돌
            {
                if (m_tBall.Direct == 1)
                    m_tBall.Direct = 2;
                else if (m_tBall.Direct == 2)
                    m_tBall.Direct = 1;
                else if (m_tBall.Direct == 5)
                    m_tBall.Direct = 4;
                else if (m_tBall.Direct == 4)
                    m_tBall.Direct = 5;

                return 1; //방향이 바뀐다.
            }

            return 0;
        }
        


        public void Initialize() //초기화 하는 함수 -> 생성자 만들 시 해도 되고 함수로 진행해도 됨
        {
            m_tBall.Ready = 0; //공 안움직임 1 움직임 0
            m_tBall.Direct = 1;
            m_tBall.X = 30;
            m_tBall.Y = 10;

            //커서 안보이게 하기
            Console.CursorVisible = false;
        }

        public void Progress()
        {
            if (m_tBall.Ready == 0) //0은 움직이는 경우
            {
                //공의 방향에 따른 스위치 문
                switch (m_tBall.Direct)
                {
                    case 0: //위 방향
                        if(Collision(m_tBall.X, m_tBall.Y-1)==0)
                            m_tBall.Y--;
                        break;
                    case 1: //오른쪽 위 방향, x좌표는 증가, y좌표는 감소
                        if (Collision(m_tBall.X+1, m_tBall.Y - 1) == 0) {
                            m_tBall.X++;
                            m_tBall.Y--;
                        }
                        break;
                    case 2: //오른쪽 아래 방향
                        if (Collision(m_tBall.X + 1, m_tBall.Y + 1) == 0)
                        {
                            m_tBall.X++;
                            m_tBall.Y++;
                        }
                        break;
                    case 3: //아래 방향
                        if (Collision(m_tBall.X, m_tBall.Y + 1) == 0)
                        {
                            m_tBall.Y++;
                        }
                        break;
                    case 4: //왼쪽 아래 방향
                        if (Collision(m_tBall.X - 1, m_tBall.Y + 1) == 0)
                        {
                            m_tBall.X--;
                            m_tBall.Y++;
                        }
                        break;
                    case 5: //왼쪽 위 방향
                        if (Collision(m_tBall.X - 1, m_tBall.Y - 1) == 0)
                        {
                            m_tBall.X--;
                            m_tBall.Y--;
                        }
                        break;

                }
            }
            
        }

        public void Render() //이미지 화
        {
            ScreenWall();
            Program.gotoxy(m_tBall.X, m_tBall.Y);
            Console.Write("●");
        }

        public void Release() { }


    }
}
