using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_6
{

    //IEnumerator를 사용하는 이유
    //✔ 컬렉션을 직접 제어하며 순회할 수 있음
    //✔ foreach 없이도 컬렉션 순회 가능
    //✔ LINQ나 커스텀 컬렉션을 만들 때 유용함

    //public interface IEnumerator
    //{
    //    bool MoveNext(); // 다음 요소로 이동 (이동할 요소가 있으면 true 반환)
    //    object Current { get; } // 현재 요소 반환
    //    void Reset(); // 처음 위치로 리셋
    //}

    //class SimpleCollection : IEnumerable<int>
    //{
    //    private int[] data = { 1, 2, 3, 4, 5 };

    //    public IEnumerator<int> GetEnumerator()
    //    {
    //        foreach (var item in data)
    //        {
    //            yield return item;
    //        }
    //    }
    //    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    //}


    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList { "apple", "banana", "cherry" };

            //IEnumerator enumerator = list.GetEnumerator(); //열거자 가져오기

            //while (enumerator.MoveNext()) //다음 요소가 있는지 확인
            //{
            //    Console.WriteLine(enumerator.Current);//현재 요소 출력
            //}


            //var collection = new SimpleCollection();

            //foreach (var i in collection)
            //{
            //    Console.WriteLine(i);
            //}

            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach (var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}

            //int? nullableInt = null; //?을 이용해 값 형식에 null을 허용

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //nullableInt = 10;

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //?? 연산자를 사용해 null인 경우 대체 값을 제공하고, ?.은 null안전 접근을 합니다.
            //둘 다 if문으로 표현 가능하지만, 코드길이를 줄일 수 있는 장점이 있다.

            //string str = null;
            //Console.WriteLine(str ?? "DefaultValue"); //str이 null인 경우 DefaultValue 출력
            ////Console.WriteLine(str.Length);//str이 null인 경우 에러 발생
            //Console.WriteLine(str?.Length);//str이 null이여도 무시하고 다음 코드 진행

            //str = "Hello";
            //Console.WriteLine(str ?? "DefaultValue");
            //Console.WriteLine(str?.Length); //str이 null이 아니므로 길이 출력

            //LINQ는 확장 매서드 형태로 제공된다.
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수있습니다.
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var evenNumbers = numbers.Where(n => n % 2 == 0);

            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}

        }
    }
}
