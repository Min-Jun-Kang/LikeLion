using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_pr
{
    public class MainGame
    {
        public Player c_Player = null; //플레이어 객체 초기화

        public void Initialize() //초기화 하는 함수
        {
            //플레이어 생성
            c_Player = new Player();
            //플레이어 직업 선택
            c_Player.SelectCharacter();
        }

        //게임의 전체적인 진행과정 관리
        public void Progress()
        {
            //게임의 진행과정 -> 캐릭터 선택 이후의 과정들

            while (true)
            {
                Console.Clear(); //캐릭터 선택 이후 화면 정리
                c_Player.Stat(); //플레이어 정보 출력
                Console.Write("1. 사냥 2. 종료 : ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 2)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Environment.Exit(0);
                }
                
            }
        }

        public MainGame() { }

        ~MainGame() { }
    }
}
