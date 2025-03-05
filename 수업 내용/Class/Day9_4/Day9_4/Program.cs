using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_4
{
    class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("멍멍!");
        }
        public void WagTail()
        {
            Console.WriteLine("꼬리를 흔든다.");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Animal ani = new Animal();
            Dog dog = new Dog();
            ani = (Animal)dog;
            dog = (Dog)ani; //형 변환 개념으로 이해하면 쉽다.

            double fl = 2.0;
            int nol = 2;

            fl = nol;
            nol = (int)fl;

            Animal myAnimal = new Dog(); //업캐스팅

            myAnimal.speak(); //오버라이딩

            Dog myDog = (Dog)myAnimal; //다운캐스팅

            myDog.WagTail();

            Animal myAni = new Animal();

            myAni.speak();
            

        }
    }
}
