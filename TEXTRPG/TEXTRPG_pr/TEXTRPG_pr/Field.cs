using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_pr
{
    public class Field
    {
        //몬스터와 플레이어가 싸우는 공간

        Player Player = null; //플레이어 객체

        Monster Monster = null; //몬스터 객체

        //MainGame에서 생성한 플레이어 불러오기
        public void SetPlayer(ref Player pPlayer)
        {
            Player = pPlayer;
        }

        public void Progress()
        {
            //사냥터 선택 화면
            while (true)
            {
                Console.Clear();
                Player.Render(); // 캐릭터 정보
                DrawMap(); // 사냥터 정보

                int input = int.Parse(Console.ReadLine());

                if (input == 4)
                    break; //이전 화면

                if (input <= 3 && input > 0)
                {
                    //전투 과정
                    CreateMonster(input);
                    Fight();
                }

            }
        }

        public void Create(string Name, int Hp, int Attack, out Monster Monster)
        {
            Monster = new Monster(); //몬스터 생성
            INFO tMonster = new INFO(); //몬스터 데이터

            tMonster.Name = Name;
            tMonster.Hp = Hp;
            tMonster.Attack = Attack;

            Monster.SetMonster(tMonster); //생성된 데이터 INFO 클래스타입 데이터 세팅

        }

        public void CreateMonster(int input)
        {
            //난이도 설정
            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 3, out Monster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, out Monster);
                    break;
                case 3:
                    Create("고수몹", 90, 9, out Monster);
                    break;
            }
        }
        public void Fight()
        {
            //전투
            while (true)
            {
                Console.Clear(); //화면 정리
                Player.Render(); //플레이어 정보
                Monster.Render(); //몬스터 정보

                Console.WriteLine("1.공격 2.도망 : ");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Player.SetHp(Monster.GetMonster().Attack);
                    Monster.SetHp(Player.GetPlayer().Attack);

                    if (Player.GetPlayer().Hp <= 0) //플레이어가 죽을 경우
                    {
                        Player.GetPlayer().Hp = 100;
                        break;
                    }
                }

                if (input == 2 || Monster.GetMonster().Hp <= 0) //도망 혹은 전투 승리
                {
                    Monster = null;
                    break;
                }

            }
        }



        public void DrawMap() 
        {
            //사냥터
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 이전화면");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택해주세요 : ");
        }

        public Field() { }
        ~Field() { }

    }
}
