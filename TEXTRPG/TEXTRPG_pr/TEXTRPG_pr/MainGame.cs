using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_pr
{
    public class MainGame
    {
        public Player Player = null; //플레이어 객체
        public Field Field = null;

        public void Initialize() //초기화
        {
            
            if (Player == null)
            {
                //플레이어 생성
                Player = new Player();
                //플레이어 캐릭터 선택
                Player.SelectCharacter();
            }
                
        }

        //게임의 전체적인 진행과정
        public void Progress()
        {
            
            while (true)
            {
                Console.Clear();//화면 정리
                Player.Render(); //플레이어 정보 출력

                Console.WriteLine("1. 사냥 2. 종료 : ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1) 
                {
                    if (Field == null)
                    {
                        Field = new Field();

                        Field.SetPlayer(ref Player);
                    }
                    Field.Progress();
                }

                if (choice == 2)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }
                
            }
        }

        public MainGame() { }

        ~MainGame() { }
    }
}
