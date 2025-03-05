using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace example2
{
    //SkillSystem

    class Skill
    {
        public string Name; //스킬 이름
        public int ManaCost; //마나 소모량
        public int CoolDown; //쿨타임
        public int LastUsedTime; //마지막 사용시간 (TickCount 기준)

        public Skill(string name, int manaCost, int coolDown)
        {
            Name = name;
            ManaCost = manaCost;
            CoolDown = coolDown*1000; //초를 밀리초로 변환
            LastUsedTime = 0; //처음엔 사용하지 않은 상태
        }
        //스킬 사용 가능 여부 확인
        public bool CanUse(int playerMana)
        {
            int currentTime = Environment.TickCount;
            if (playerMana < ManaCost)
            {
                Console.WriteLine($"마나가 부족합니다! (필요 MP : {ManaCost}");
                return false;
            }
            if (currentTime - LastUsedTime < CoolDown)
            {
                int remainingTime = (CoolDown - (currentTime - LastUsedTime)) / 1000;
                Console.WriteLine($"{Name} 스킬은 아직 사용할 수 없습니다. (남은 시간 : {remainingTime}초)");
                return false;
            }

            return true;
        }

        //스킬 사용

        public void Use(ref int playerMana)
        {
            if (!CanUse(playerMana)) return;

            playerMana -= ManaCost; //플레이어 마나 참조로 외부 값도 같이 조정 동기화
            LastUsedTime = Environment.TickCount; //현재 시간을 저장

            Console.WriteLine($"{Name} 스킬 사용! (MP - {ManaCost})");

        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            int playerMana = 200; //플레이어 초기 마나
            //스킬 목록 (배열 사용)
            Skill[] skills = new Skill[]
            {
                new Skill("파이어볼",20,10), //스킬 이름, 마나 소모량, 쿨타임
                new Skill("얼음창",15,10),
                new Skill("힐",30,15),
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"현재 MP: {playerMana}");
                Console.WriteLine("사용 가능한 스킬: ");
                for (int i = 0; i < skills.Length; i++) 
                {
                    Console.WriteLine($"{i + 1}. {skills[i].Name} (MP {skills[i].ManaCost} 쿨다운 {skills[i].CoolDown / 1000}s)");   
                }
                Console.WriteLine("0. 종료");
                Console.Write("사용할 스킬의 번호를 입력하세요 : ");
                try
                {
                    int skillIndex = int.Parse(Console.ReadLine());

                    if (skillIndex == 0) 
                    { 
                        Console.WriteLine("게임을 종료합니다.");
                        break;
                    }
                    if (skillIndex > 0 && skillIndex <= skills.Length)
                    {
                        skills[skillIndex - 1].Use(ref playerMana);
                    }
                    else
                    {
                        Console.WriteLine("스킬 개수 내의 범위를 입력하세요.");
                    }
                }
                catch 
                {
                    Console.WriteLine("숫자를 입력하세요!");
                }

                Thread.Sleep(1000); //CPU과부화 방지
            }
        }
    }
}
