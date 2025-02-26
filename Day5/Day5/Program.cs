using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////배열
            ////0부터 시작한다.

            //int[] num = new int[3]; //3개의 메모리를 만든다. (메모리 할당)

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            //Console.WriteLine(num[0]);
            //Console.WriteLine(num[1]);
            //Console.WriteLine(num[2]);

            //for (int i = 0; i < 3; i++) //반복문을 통해 쉽게 배열 안의 내용을 불러올 수 있음.
            //{
            //    Console.WriteLine(num[i]);
            //}

            //배열 선언의 방법

            //int[] numbers = { 1, 2, 3 }; //간단한 배열 선언과 초기화
            //int[] numbers2 = new int[3]; //크기만 지정
            //int[] numbers3 = new int[] { 1, 2, 3 }; //초기화와 함께 선언

            //string[] fruits = { "사과", "바나나", "오렌지" }; //문자열 타입도 배열로 만들 수 있다.

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(fruits[i]);//i는 인덱스를 뜻하며 배열 안에 저장되어 있는 공간을 지정하는 것이다.
            //}

            //3명의
            //국어, 영어, 수학 점수를 입력받고
            //총점과 평균을 출력하세요.

            //int[] iKor = new int[3];
            //int[] iEng = new int[3];
            //int[] iMath = new int[3];

            //int[] sum = new int[3];
            //float[] aver = new float[3];


            ////학생입력받기

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("학생 성적입력하세요 : ");
            //    Console.Write("국어 : ");
            //    iKor[i] = int.Parse(Console.ReadLine());
            //    Console.Write("영어 : ");
            //    iEng[i] = int.Parse(Console.ReadLine());
            //    Console.Write("수학 : ");
            //    iMath[i] = int.Parse(Console.ReadLine());


            //    sum[i] = iKor[i] + iEng[i] + iMath[i];

            //    aver[i] = (float)sum[i] / 3;

            //}

            ////출력
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine((i + 1) + "번학생");
            //    Console.WriteLine($"국어 : {iKor[i]} 영어 : {iEng[i]} 수학 : {iMath[i]} ");
            //    Console.WriteLine("총점 : " + sum[i]);
            //    Console.WriteLine("평균 : " + aver[i].ToString("F2"));
            //}

            ////length 사용해서 조건문 만들기
            //int[] scores = new int[3];

            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;



            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"점수 {i + 1}:{scores[i]}");
            //}

            //double value = 123.456789;
            ////소수점 자릿수 설정하는 포맷
            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine($"소수점둘째자리 : {value:F2} ");
            //Console.WriteLine(String.Format("수소점 둘째 자리: {0:F2}",value));
            ////소수점 없이 정수 출력
            //Console.WriteLine(value.ToString("F0"));


            //double value = 123124124.12323;

            //Console.WriteLine(value.ToString("N2"));

            //2차원 배열 선언
            //int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };



            //for (int i = 0; i < 2; i++)
            //{

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{matrix[i, j]}");
            //    }
            //    Console.WriteLine();
            //}

            //int[][] matrix = new int[2][];

            //matrix[0] = new int[3];
            //matrix[1] = new int[3];


            ////값 입력
            //matrix[0][0] = 1;
            //matrix[0][1] = 2;
            //matrix[0][2] = 3;

            //matrix[1][0] = 4;
            //matrix[1][1] = 5;
            //matrix[1][2] = 6;


            ////출력
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        Console.Write(matrix[i][j] + " ");
            //    }
            //    Console.WriteLine();

            //}

            //가변 배열 vs 다차원 배열 차이점 정리
            //구분 가변 배열(int[][])    다차원 배열(int[,])
            //선언 방식    int[][] arr = new int[2][]; int[,] arr = new int[2, 3];
            //행 길이    가변적(각 행의 길이가 다를 수 있음)    고정적(모든 행의 열 개수가 같음)
            //메모리 각 행이 독립적인 배열로 관리됨    하나의 연속된 메모리 블록
            //접근 방식    arr[i][j]    arr[i, j]
            //🔥 결론
            //int[][] matrix = new int[2][3]; → ❌ 잘못된 문법
            //int[][] matrix = new int[2][]; (가변 배열 선언 후 각 행 초기화 필요)
            //int[,] matrix = new int[2, 3]; (다차원 배열, 크기 고정)
            //👉 만약 행의 크기가 고정이라면 int[,] 를 사용하고, 각 행의 크기가 다를 가능성이 있다면 int[][] 를 사용하세요! 🚀

            ////6.가변배열
            //Console.WriteLine("가변 배열");
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4, 5 };
            //jaggedArray[2] = new int[] { 6 };

            //for (int i = 0; i < jaggedArray.Length; i++) 
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++) 
            //    {
            //        Console.Write($"{jaggedArray[i][j]}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("var 키워드 사용");
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"배열 타입: {numbers.GetType()}");

        }

    }
}
