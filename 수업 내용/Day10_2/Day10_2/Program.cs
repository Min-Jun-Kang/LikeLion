using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_2
{
    //class Person
    //{
    //    public string name; //필드 or 변수 : 클래스의 데이터를 저장하는 멤버입니다.
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person p = new Person(); //객체로 만들기 인스턴스라고도 함
    //        p.name = "Alice"; //필드에 값넣기
    //        Console.WriteLine(p.name);

    //    }
    //}

    ////1. 함수를 이용해서 private한 필드 이용하는 법
    //class Person
    //{
    //    private string name = "홍길동"; //필드 클래스의 데이터를 저장하는 멤버입니다. 초기에 값을 설정할 수도 있다.
    //    public void SetName(string n) //set함수(메서드)
    //    {
    //        name = n;
    //    }
    //    public string GetName() //get함수(메서드)
    //    {
    //        return name;
    //    }

    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person p = new Person(); //객체로 만들기  인스턴스
    //        Console.WriteLine(p.GetName()); //홍길동 출력
    //        p.SetName("Bob");
    //        Console.WriteLine(p.GetName()); //set 함수로 인해 내용이 바뀐 Bob 출력
    //    }
    //}

    //생성자를 이용해 필드 값 설정하는 방법
    class Person
    {
        public string Name;
        public int Age;
        public Person() //생성자
        {
            Name = "Unknown";
            Age = 0;
        }
        public Person(string name)
        {
            Name = name;
            Age = 0;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(); //생성자 호출
            Person p1 = new Person("Bob");//1개짜리 매개변수있는 생성자
            Person p2 = new Person("카타리나", 20); //2개짜리 매개변수있는 생성자

            Console.WriteLine(p.Name + "," + p.Age);
            Console.WriteLine(p1.Name + "," + p1.Age);
            Console.WriteLine(p2.Name + "," + p2.Age);

        }
    }


}