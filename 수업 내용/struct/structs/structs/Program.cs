using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs
{
    class Program
    {
        struct Student 
        {
            public string name;
            public int kor;
            public int eng;
            public int mat;
        }


        static void Main(string[] args)
        {
            //구조체를 이용해서
            //학생 3명의 이름 성적을 받고 국어,영어,수학
            //출력하시오.
            //이름 국어 영어 수학
            //홍길동 100 80 70
            //홍길란 90 10 20
            //홍길순 20 55 70
            Student[] student = new Student[3];

            for (int i = 0; i < student.Length; i++) 
            {
                Console.Write($"{i+1}번째 학생 이름 : ");
                string name = Console.ReadLine();
                student[i].name = name;
                Console.Write("국어 성적 : ");
                int iKor = int.Parse(Console.ReadLine());
                student[i].kor = iKor;
                Console.Write("영어 성적 : ");
                int iEng = int.Parse(Console.ReadLine());
                student[i].eng = iEng;
                Console.Write("수학 성적 : ");
                int iMat = int.Parse(Console.ReadLine());
                student[i].mat = iMat;
            }
            Console.WriteLine("이름\t국어\t영어\t수학");
            for (int i = 0; i < student.Length; i++) 
            {
                Console.WriteLine($"{student[i].name}\t{student[i].kor}\t{student[i].eng}\t{student[i].mat}");
            }



        }
    }
}
