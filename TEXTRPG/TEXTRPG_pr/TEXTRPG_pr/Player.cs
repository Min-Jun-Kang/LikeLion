using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_pr
{
    public class Player
    {
        public INFO player_Info; //플레이어 데이터


        //직업 선택
        public void SelectCharacter()
        {
            player_Info = new INFO();

            const int warrior = 1;
            const int wizard = 2;
            const int archer = 3;
            const int thief = 4;

            Console.Write("직업을 선택하세요 (1. 전사, 2. 마법사, 3. 궁수, 4. 도적) : ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case warrior:
                    player_Info.Name = "전사";
                    player_Info.Attack = 10;
                    player_Info.Hp = 100;
                    break;
                case wizard:
                    player_Info.Name = "마법사";
                    player_Info.Attack = 20;
                    player_Info.Hp = 80;
                    break;
                case archer:
                    player_Info.Name = "전사";
                    player_Info.Attack = 20;
                    player_Info.Hp = 80;
                    break;
                case thief:
                    player_Info.Name = "도적";
                    player_Info.Attack = 10;
                    player_Info.Hp = 90;
                    break;
            }

        }
        //현재 선택한 직업과 체력 및 공격력 레벨 등 확인
        public void Stat() 
        {
            Console.WriteLine("======================");
            Console.WriteLine($"직업 이름 : {player_Info.Name}");
            Console.WriteLine($"체력 : {player_Info.Hp}\t공격력 : {player_Info.Attack}");
        }

        public Player() { } //생성자

        ~Player() { }//소멸자

    }
}
