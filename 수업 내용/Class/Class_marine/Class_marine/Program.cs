using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_marine
{
    //마린 클래스를 만드세요.
    //이름,미네랄  = 50
    //기본생성자 , 인자있는생성자 
    //SCV 클래스를 만드세요.
    //이름,미네랄  = 50
    //기본생성자 , 인자있는생성자 
    class Marin
    {
        public string Name;
        public int Mineral;

        public Marin()
        {
            Name = "마린";
            Mineral = 50;
        }

        public Marin(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }
    class SCV
    {
        public string Name;
        public int Mineral;

        public SCV()
        {
            Name = "SCV";
            Mineral = 50;
        }

        public SCV(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }
    //배럭클래스를 만드세요
    class Barracks 
    {
        public string Name;
        public int Mineral;

        //기본생성자
        public Barracks()
        {
            Name = "배럭스";
            Mineral = 150;
        }

        //매개변수 생성자
        public Barracks(string Name, int Mineral)
        {
            //this 키워드 사용
            //this.Name은 클래스 내 Name 변수 의미
            this.Name = Name;
            //Name은 배럭스 함수내의 매개변수를 의미
            this.Mineral = Mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }
    //미네랄 클래스를 만드시오
    //Mineral 1500 (한 덩이에)
    //7덩이 시작
    //클래스화 해봅시다.
    class Mineral 
    {
        public int count; 
        
        public Mineral()
        {
            this.count = 1500;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 갯수 : {count}");
        }
    }
    //Game클래스를 만들어보자
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount; //인구 수

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 : {mineral}, 가스 : {gas}, 인구 수 : {charCount}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 10;
            Game.ShowInfo();



            Marin marin = new Marin("불꽃 테란", 100);
            SCV scv = new SCV("열받은 SCV", 70);
            Barracks barracks = new Barracks("불타는 배럭스", 100);
            //클래스의 배열 생성
            Mineral[] mineral = new Mineral[7];
            //각 배열에 new 객체화
            for (int i = 0; i < mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }

            marin.ShowInfo();
            scv.ShowInfo();
            barracks.ShowInfo();
        }
    }
}
