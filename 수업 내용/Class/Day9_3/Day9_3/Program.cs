using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_3
{
    class Player
    {
        public string name;

        public void Render()
        {
            Console.WriteLine("플레이어" + name);
        }
    }

    class Wizard : Player
    {
        public string job;
        public void Render2()
        {
            Console.WriteLine("직업은 " + job + "입니다.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();  //객체

            p.name = "홍길동";
            p.Render();
            //p.Render2(); //접근 불가


            Wizard w = new Wizard(); //얘는 player에도 접근가능
            w.name = "대마법사 샤우론";
            w.job = "마법사";

            w.Render();
            w.Render2();
        }
    }
}
