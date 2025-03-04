using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_3
{
    //컬렉션(List, Queue, Stack) 활용
    //List<string>을 생성하고 "사과", "바나나", "포도"를 추가하세요.
    //Queue<string> 을 생성하고 "첫 번째 작업", "두 번째 작업", "세 번째 작업"을 추가하세요.
    //Stack<int> 을 생성하고 10, 20, 30을 추가한 뒤 하나씩 출력하세요.

    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("사과");
            list.Add("바나나");
            list.Add("포도");

            Console.WriteLine("List 안의 정보");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }


            Queue<string> queue = new Queue<string>();
            queue.Enqueue("첫 번째 작업");
            queue.Enqueue("두 번째 작업");
            queue.Enqueue("세 번째 작업");

            Console.WriteLine("Queue 안의 정보");
            while (queue.Count>0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine("Stack 안의 정보");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

        }
    }
}
