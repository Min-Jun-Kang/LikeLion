using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_5
{
    class Program
    {
        //제네릭 사용하기(Generics)
        //<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들수있습니다.
        class Cup<T>
        {
            public T Content { get; set; } //T 부분에 원하는 타입을 맞춰서 적으면 된다.
        }


        static void Main(string[] args)
        {
            //Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            //Console.WriteLine($"CupOfString: {cupOfString.Content}");
            //Console.WriteLine($"cupOfInt: {cupOfInt.Content}");

            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

        }
    }
}
