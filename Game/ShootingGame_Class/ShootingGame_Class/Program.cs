using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame_Class
{
    //미사일 클래스
    //좌표 이용
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }
    //플레이어 클래스
    public class PLAYER
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴 키를 누르면 바로 반응함

        public int playerX; //플레이어 x좌표
        public int playerY; //플레이어 y좌표
        public BULLET[] playerBullet = new BULLET[20];
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;

        public PLAYER() //생성자
        {
            //플레이어 좌표위치 초기화
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++) 
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }


        }
        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            //플레이어 그리기
            PlayerDraw();
            //SCORE 표시
            UIscore();
            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }
        }

        public void KeyControl()
        {
            int pressKey; //정수형 변수선언 키값 받을 용

            if (Console.KeyAvailable) //키가 눌렸을 때 true
            {
                pressKey = _getch(); //아스키값 왼쪽 오른쪽, 아스키 표 보고 참고
                if (pressKey == 0 || pressKey == 224) 
                {
                    pressKey = _getch();
                    switch (pressKey)
                    {
                        case 72: //위쪽 방향키 아스키 코드
                            playerY--;
                            if (playerY < 1)
                                playerY = 1;
                            break;
                        case 75: //왼쪽 화살표 
                            playerX--;
                            if (playerX < 0)
                                playerX = 0;
                            break;
                        case 77: //오른쪽
                            playerX++;
                            if (playerX >75)
                                playerX = 75;
                            break;
                        case 80: //아래
                            playerY++;
                            if (playerY > 21)
                                playerY = 21;
                            break;
                    }
                }
                switch (pressKey)
                {
                    case 32: //스페이스바
                             //총알 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사 가능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 (x좌표+5)
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1; //가운데 본체 위치
                                //한 발씩 쏘는 용
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사 가능
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 (x좌표+5)
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY; //본체 위
                                //한 발씩 쏘는 용
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사 가능
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 (x좌표+5)
                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 2; //본체 아래
                                //한 발씩 쏘는 용
                                break;
                            }
                        }

                        break;
                }

            }
            
        }
        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; //배열 문자열로 플레이어 그리기

            for (int i = 0; i < player.Length; i++) 
            {
                //콘솔좌표 설정 플레이어X 플레이어Y
                Console.SetCursorPosition(playerX, playerY+i);
                //문자열배열 출력
                Console.WriteLine(player[i]);
            }
        }
        
        public void BulletDraw()
        {
            string bullet = "->"; //미사일 모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet[i].x-1, playerBullet[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet[i].x++; //미사일 오른쪽으로 날리기

                    if (playerBullet[i].x > 78) // 콘솔 크기에 맞춰
                    {
                        playerBullet[i].fire = false; //미사일 다시 준비 상태
                    }

                }
            }
        }
        public void BulletDraw2()
        {
            string bullet = "->"; //미사일 모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet2[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet2[i].x++; //미사일 오른쪽으로 날리기

                    if (playerBullet2[i].x > 78) // 콘솔 크기에 맞춰
                    {
                        playerBullet2[i].fire = false; //미사일 다시 준비 상태
                    }

                }
            }
        }
        public void BulletDraw3()
        {
            string bullet = "->"; //미사일 모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet3[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet3[i].x++; //미사일 오른쪽으로 날리기

                    if (playerBullet3[i].x > 78) // 콘솔 크기에 맞춰
                    {
                        playerBullet3[i].fire = false; //미사일 다시 준비 상태
                    }

                }
            }
        }


        //충돌 처리
        public void ClashEnemyAndBullet(ENEMY enemy)
        {
            //미사일 20
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1)
                            && playerBullet[i].x <= (enemy.enemyX+1)) //충돌 
                        {
                            //충돌
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;


                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            //스코어 올리기 : 적과 충돌은 적을 처치했다는 뜻이기 때문에
                            Score+=100;

                            playerBullet[i].fire = false; //미사일도 준비 상태로 만들어야함.
                        }
                    }

                }
            }
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일2
                if (playerBullet2[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1)
                            && playerBullet2[i].x <= (enemy.enemyX + 1)) //충돌 
                        {
                            //충돌
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;


                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            //스코어 올리기 : 적과 충돌은 적을 처치했다는 뜻이기 때문에
                            Score += 100;

                            playerBullet2[i].fire = false; //미사일도 준비 상태로 만들어야함.
                        }
                    }

                }
            }
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일3
                if (playerBullet3[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        if (playerBullet3[i].x >= (enemy.enemyX - 1)
                            && playerBullet3[i].x <= (enemy.enemyX + 1)) //충돌 
                        {
                            //충돌
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;


                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            //스코어 올리기 : 적과 충돌은 적을 처치했다는 뜻이기 때문에
                            Score += 100;

                            playerBullet3[i].fire = false; //미사일도 준비 상태로 만들어야함.
                        }
                    }

                }
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //아이템 충돌이 일어나면 양쪽 미사일 발사
        public void CrashItem()
        {
            if (playerY + 1 == item.itemY) 
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;
                    if (itemCount < 3)
                        itemCount++;

                    for (int i = 0; i < 20; i++) //총알 초기화
                    {
                        playerBullet[i] = new BULLET();
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new BULLET();
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;

                        playerBullet3[i] = new BULLET();
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;
                    }
                }
            }


        }


    }
    //적 클래스
    public class ENEMY
    {
        public int enemyX;
        public int enemyY;

        public ENEMY()
        {
            //적 좌표 초기화
            enemyX = 77;
            enemyY = 12;
        }
        //적 그리기
        public void EnemyDraw()
        {
            string enemy = "<-0->"; //문자열로 표현
            Console.SetCursorPosition(enemyX, enemyY); //좌표설정
            Console.Write(enemy);//출력
            
        }
        //적 움직이기
        public void EnemyMove()
        {
            Random rand = new Random(); //랜덤
            enemyX--; //왼쪽으로 움직임

            if (enemyX < 2) //화면 왼쪽 넘어가면 새로 좌표 잡아라
            {
                enemyX = 75; //좌표 75
                enemyY = rand.Next(2, 22); //2~21
            }
            
        }

    }
    //아이템 클래스
    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;
        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "★Item★";
            Console.Write(ItemSprite);
        }

        public void ItemMove()
        {
            if (itemX <= 1 || itemY <= 1)
            {
                ItemLife = false;
            }

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);


            //플레이어 생성
            PLAYER player = new PLAYER();
            //적 생성
            ENEMY enemy = new ENEMY();

            //유니티처럼 속도 프레임
            int dwTime = Environment.TickCount; // 1/1000 초가 흐른다.(현재 시간)

            while (true) //무한 반복
            {
                //0.05초 지연
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어
                    player.GameMain();
                    //총알
                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }
                    //적
                    enemy.EnemyDraw();
                    enemy.EnemyMove();
                    //충돌처리
                    player.ClashEnemyAndBullet(enemy);


                }
            }


        }
    }
}
