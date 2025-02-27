using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {
            ////2진수를 정수로 변환
            //Console.Write("2진수를 입력하세요 : ");
            //string binaryInput = Console.ReadLine(); //문자열 입력 받기
            //int decimalVallue = Convert.ToInt32(binaryInput, 2); //2진수 -> 10진수 변환

            ////정수를 2진수로 변환
            //string binaryOutput = Convert.ToString(decimalVallue, 2); //10진수 -> 2진수 변환

            //Console.WriteLine($"입력한 2진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalVallue}");
            //Console.WriteLine($"다시 2진수로 변환 : {binaryOutput}");

            ////var를 사용하여 변수 선언
            //var name = "Alice"; //문자열로 추론
            //var age = 25; //정수로 추론
            //var isStudent = true; //논리값으로 추론

            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");

            ////default 키워드를 이용한 기본 값 설정

            //int defaultInt = default; //기본 값은 0
            //string defaultString = default; //기본 값은 null
            //bool defaultBool = default; //기본 값은 false

            //Console.WriteLine($"정수 기본 값 : {defaultInt}");
            //Console.WriteLine($"문자열 기본 값 : {defaultString}");
            //Console.WriteLine($"논리값 기본 값 : {defaultBool}");


            //int a = 5, b = 3;

            //int sum = 0;

            //int number = 7;


            //int sum = 0;


            //sum = number % 2;  // 0나오면 짝수   1 홀수

            //Console.WriteLine("짝수 홀수 판별 : " + sum);

            //sum = a + b; //산술 연산자 사용, 오른쪽에서 왼쪽으로 넘겨준다.
            //Console.WriteLine($"합 : {sum}");
            //sum = a - b; // 빼기
            //Console.WriteLine($"차 : {sum}");
            //sum = a * b; // 곱하기
            //Console.WriteLine($"곱 : {sum}");
            //sum = a / b; // 나누기(몫)
            //Console.WriteLine($"몫 : {sum}");
            //sum = a % b; // 나누기(나머지)
            //Console.WriteLine($"나머지 : {sum}");

            //bool isEqual = false; //거짓 0

            //int a = 5;
            //int b = 2;
            //int c = 5;

            //isEqual = (a == c);

            //Console.WriteLine($"같은 가? : {isEqual}");

            ////단항 연산자
            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number); //양수 출력 : 5
            //Console.WriteLine(-number); //음수 출력 : -5

            //Console.WriteLine(!flag);  //논리 부정 : false  

            //int num = 10; // 0000 1010
            //int result = ~num; //모든 비트 반전 : 1111 0101, 결과 -11

            //Console.WriteLine($"반전 : {result}");

            ////캐스팅
            //double pi = 3.14;
            //int integerPi = (int)pi; //실수형 -> 정수형으로 변환, 소수점 밑은 다 버림

            //Console.WriteLine(integerPi); // 출력 값: 3

            //int iKor = 90; //국어 점수
            //int iEng = 75; //영어 점수
            //int iMath = 58; //수학 점수

            //int sum = 0; //점수 총 합
            //float average = 0.0f; //점수 평균 값

            //sum = iKor + iEng + iMath;
            //average = sum / 3;
            //float average1 = (float)sum / 3; // 원래는 정수끼리의 계산이기 때문에 결과가 정수로 나오게 되지만
            //// sum과 3 중 하나를 float으로 캐스팅하여 결과 값을 실수로 만드는 것이다.

            //Console.WriteLine($"총점 : {sum}");
            //Console.WriteLine($"평균 : {average}");
            //Console.WriteLine($"평균 : {average1}");

            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //문자열 연결 연산자
            // +는 같은 타입끼리

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName); //출력 Alice Smith
            //Console.WriteLine(firstName + lastName);

            ////할당 연산자

            //int a = 10;
            //a += 5;  // a(15)  = a(10) + 5; 
            //Console.WriteLine(a);
            //a -= 5;  // a(10)  = a(15) - 5;
            //Console.WriteLine(a);
            //a *= 5;  // a(50)  = a(10) * 5;
            //Console.WriteLine(a);
            //a /= 5;  // a(10)  = a(50) / 5;
            //Console.WriteLine(a);
            //a %= 5;  // a(0)  = a(10) % 5;
            //Console.WriteLine(a);

            //문제 1.학점 평균 계산 프로그램
            //설명:
            //국어, 영어, 수학 점수를 사용자로부터 입력받아 총점과 평균을 구하는 프로그램을 작성하세요.
            //요구사항:

            //각 과목의 점수는 정수형으로 입력받습니다.
            //총점을 구한 후, 평균을 계산할 때 정수형 총점을 실수형으로 캐스팅하여 소수점까지 정확하게 계산합니다.
            //평균은 소수점 둘째 자리까지 출력하세요.
            //문제 2.비트 반전(~) 연산자 활용 프로그램
            //설명:
            //사용자로부터 정수를 입력받아, 해당 정수의 모든 비트를 반전(~)한 결과를 출력하는 프로그램을 작성하세요.
            //요구사항:

            //정수를 입력받습니다.
            //비트 반전 연산자(~)를 이용하여 입력된 정수의 비트를 반전합니다.
            //원래의 값과 비트 반전 후의 값을 함께 출력합니다.

            ////증감 연산자

            //int b = 3;
            //int a = 5;
            ////전위 ++b, 후위 b++

            //Console.WriteLine("b의 값은 : " + (b++)); //이 줄에서 계산되지 않음
            //Console.WriteLine("b의 값은 : " + (b)); //다음 줄 부터 적용
            //Console.WriteLine("a의 값은 : " + (++a)); //이 줄에서 계산 됨
            //Console.WriteLine("a의 값은 : " + (a)); //다음 줄 부터 적용

        }
    }
}
