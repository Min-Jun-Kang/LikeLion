using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_GetSet
{
    class Program
    {
        // Get/Set 방식으로 이용(캡슐화 -> 안전성을 높이는 방법)
        //class Person
        //{
        //    private string name; //내부 변수 private(다른 클래스에서 건드릴 권한이 없음)

        //    //값 설정하기 (Setter)
        //    public void SetName(string newName)
        //    {
        //        name = newName;
        //    }

        //    //값 가져오기 (Getter)
        //    public string GetName()
        //    {
        //        return name;
        //    }
        //}

        ////C# 프로퍼티 property 
        //class Person
        //{
        //    private string name; //내부변수
        //    public string Name //프로퍼티
        //    {
        //        get { return name; } //Getter
        //        set { name = value; } //Setter
        //    }
        //}

        ////자동 구현 프로퍼티
        //class Person
        //{
        //    public string Name { get; set; } 
        //}
        //프로퍼티 자동 구현 
        class Person
        {
            private int count = 100;
            public string Name { get; set; } //자동 구현 프로퍼티
            public int Count
            {
                get { return count; } //읽기만 가능
            }

            public float Balance { get; private set; } //외부 변경 불가

            public void AddBal()
            {
                Balance += 100;
            }


        }

        static void Main(string[] args)
        {
            //C#에서 get/set 방식의 함수와 프로퍼티 비교
            //C#에서는 객체의 값을 읽고(get), 설정(set)하는
            //방식으로 함수(get/set 메서드) 또는
            //**프로퍼티(Property)**를 사용할 수 있습니다.

            // Get/Set 방식으로 이용(캡슐화 -> 안전성을 높이는 방법)
            //Person p = new Person();

            //p.SetName("홍길동");

            //Console.WriteLine("이름 : " + p.GetName());

            ////C# 프로퍼티 property 
            //Person p = new Person();

            //p.Name = "홍길동";

            //Console.WriteLine("이름 : " + p.Name);

            ////자동 구현 프로퍼티
            //Person p = new Person();

            //p.Name = "홍길동";

            //Console.WriteLine("이름 : " + p.Name);

            Person p = new Person();

            p.Name = "홍길동";
            p.AddBal();
            Console.WriteLine("이름 : " + p.Name + "Count : " + p.Count + "Balance " + p.Balance);

        }
    }
}
