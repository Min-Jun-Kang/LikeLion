using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_pr
{
    public class Monster
    {
        public INFO monster_Info; //몬스터 데이터

        //몬스터 체력 공격력 설정

        //Attack만큼 현재 체력 감소
        public void SetHp(int Received_Damage)
        {
            monster_Info.Hp -= Received_Damage;
        }

        //INFO 클래스 타입 인자로 몬스터 데이터 삽입
        public void SetMonster(INFO tMonster)
        {
            monster_Info = tMonster;
        }
        public INFO GetMonster()
        {
            return monster_Info;
        }

        public void Stat()
        {
            Console.WriteLine("=========================");
            Console.WriteLine($"몬스터 이름 : {monster_Info.Name}");
            Console.WriteLine($"체력 : {monster_Info.Hp}\t 공격력 : {monster_Info.Attack}");
        }

        public Monster() { } // 기본 생성자
        ~Monster() {} //소멸자

    }
}
