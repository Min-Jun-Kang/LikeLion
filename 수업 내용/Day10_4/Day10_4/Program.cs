using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_4
{
    class Program
    {
        //ref 포인터개념 참조
        //메서드 ref, out
        static void Increase(ref int x)
        {
            x++;
        }

        static void Increase1(int x)
        {
            x++;
        }
        static int Increase2(int x)
        {
            return x++;
        }


        static void Main(string[] args)
        {
            int a = 10;
            Increase(ref a); //연동 된다. (같은 주소를 쓰기 때문에 얘만 반응이 되는 것)

            int b = 10;
            Increase1(b); //반응이 없다.

            int c = 10;
            Increase2(c); //반응이 없다.

            //여기서 들어가는 변수 b,c는 각자의 주소이기 때문에 위에 함수에서 적혀있는 x++이 반응되지 않는다.

            Console.WriteLine("A의 값 : " + a);
            Console.WriteLine("B의 값 : " + b);
            Console.WriteLine("C의 값 : " + c);
        }
    }
}
