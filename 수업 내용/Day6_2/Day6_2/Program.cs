using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//네임스페이스
//클래스, 함수, 변수 이름이 충돌하는 것을 방지하기 위해 사용된다.

namespace dev1
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("안녕하세요 !MyNamespace의 MyClass입니다.");
        }
    }
}


namespace Day6_2
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("ㅎㅎㅎㅎㅎ");
        }

        static void Main(string[] args)
        {
            SayHello(); //namespcae Day6_2에 있는 SayHello함수
            dev1.MyClass.SayHello(); //namespce MyClass에 있는 SayHello함수
        }
    }
}
