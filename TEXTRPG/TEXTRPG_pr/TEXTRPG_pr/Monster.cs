using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG_pr
{
    public class Monster
    {

        public INFO Monster_Info; //몬스터 데이터

        //몬스터 체력 공격력 설정
        //데미지를 받을 시 현재 체력 감소
        public void SetHp(int Received_Damage)
        {
            Monster_Info.Hp -= Received_Damage;
        }

        public void SetMonster(INFO tMonster)
        {
            Monster_Info = tMonster;
        }
        public INFO GetMonster()
        {
            return Monster_Info;
        }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine($"몬스터 이름 : {Monster_Info.Name}");
            Console.WriteLine($"체력 : {Monster_Info.Hp}\t 공격력 : {Monster_Info.Attack}");
        }

        public Monster() { } // 기본 생성자
        ~Monster() {} //소멸자

    }
}
