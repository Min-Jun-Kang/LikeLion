using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열과 컬렉션
            //배열과 비슷하지만 동적으로 크기가 변하는 가변 길이 컬렉션

            //리스트(List)
            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave");
            //names.Remove("Bob");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //List<int> list = new List<int>(); //메모리를 할당해주는 것이 좋다.

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //Console.WriteLine(list.Count);//3개 값을 넣음

            //list.Insert(1, 100);//인덱스 번호, 원하는 값 : 인덱스 번호 위치에 원하는 값을 추가함(삽입)
            //Console.WriteLine(list.Count);//insert로 인해 값이 하나 추가됨

            //list[2] = 200;//값을 수정하는 용도

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Stack //마지막에 들어간게 먼저 나옴 LIFO

            //Stack stack = new Stack();

            //stack.Push(1); //push 내용 넣기
            //stack.Push(2);
            //stack.Push(3);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop()); //pop 내용 빼기
            //}

            //Queue //먼저 들어간게 먼저나옴 FIFO

            //Queue queue = new Queue();

            //queue.Enqueue(1); //내용 넣기
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue()); //내용 빼기
            //}

            //Queue queue = new Queue();

            //queue.Enqueue("q");
            //queue.Enqueue("w");
            //queue.Enqueue("e");
            //queue.Enqueue("r");
            //queue.Enqueue("점멸");
            //queue.Enqueue("평타");


            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //Queue queue1 = new Queue();

            //queue1.Enqueue("→");
            //queue1.Enqueue("↓");
            //queue1.Enqueue("↘");
            //queue1.Enqueue("→");
            //queue1.Enqueue("풍신권");



            //while (queue1.Count > 0)
            //{
            //    Console.WriteLine(queue1.Dequeue());
            //}

            //Console.WriteLine(queue1.Count);

            ////ArrayList 생성
            ////크기가 동적으로 조정되는 배열, 다양한 형식의 데이터를 저장할수있다.(중요)
            //ArrayList arrayList = new ArrayList();

            ////요소추가
            //arrayList.Add(1);  //정수
            //arrayList.Add("Hello");  //문자열
            //arrayList.Add(3.14);    //실수


            ////요소 접근
            //Console.WriteLine("ArrayList 요소: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            ////요소 제거
            //arrayList.Remove(1);

            //Console.WriteLine("\n ArrayList요소 제거 후: ");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            ////Hashtable 클래스
            ////키-값 쌍을 저장하는 컬렉션이다. 
            ////키를 이용해 값을 빠르게 검색

            //Hashtable hashtable = new Hashtable();

            ////키-값 쌍 추가
            //hashtable["Alice"] = 25;
            //hashtable["Bob"] = 30;
            //hashtable["포션"] = 20;

            //Console.WriteLine("Hashtable 요소:");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            //}


            ////특정 키의 값 가져오기
            //Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}");

            ////요소제거
            //hashtable.Remove("Bob");

            //Console.WriteLine("Hashtable 요소:");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            //}

        }
    }
}
