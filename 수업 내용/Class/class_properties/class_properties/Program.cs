using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_properties
{
    //마린클래스
    //프로퍼티를 이용해서 이름과 미네랄을 만드시오. 이름 마린, 미네랄 50
    class Marine
    {
        public string Name { get; private set; } = "마린"; //private set을 통해 이름을 못 바꾸게 만듦
        public int Mineral { get; set; } = 50;
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Marine m = new Marine();
            Console.WriteLine($"유닛 : {m.Name}, 가격 : {m.Mineral} 미네랄");
        }
    }
}
