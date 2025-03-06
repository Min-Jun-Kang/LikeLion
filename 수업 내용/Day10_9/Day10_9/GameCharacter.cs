using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_9
{
    public abstract class GameCharacter //추상 클래스
    {
        public string Name { get; set; } //필드 변수 생성, get set을 이용해서
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        protected GameCharacter(string name, int health, int attack, int defense) //protected
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }


        //추상메서드 : 모든 캐릭터가 구현해야 하는 기본 공격
        public abstract void BasicAttack(GameCharacter target);

        //추상메서드 : 모든 캐릭터가 구현해야하는 특수 공격
        public abstract void SpecialAttack(GameCharacter tagert);

        //일반 메서드 : 모든 캐릭터가 공유하는 기능
        public void TakeDamage(int damage)
        {
            int actualDamage = Math.Max(1, damage - Defense);

            Health = Math.Max(0, Health - actualDamage);

            Console.WriteLine($"{Name}이 {actualDamage}의 피해를 받았습니다. 남은체력 : {Health}");

        }

    }
}
