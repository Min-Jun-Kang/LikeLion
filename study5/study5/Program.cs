using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            //int integerNum = 10;    //정수 데이터
            //float floatNum = 3.14f; //단정밀도 실수, float 사용 시 실수 뒤에 f를 붙여야 함
            //double doubleNum = 3.14159; //배정밀도 실수

            //Console.Write(integerNum);
            //Console.WriteLine(floatNum);
            //Console.Write(doubleNum);

            ////정수 데이터형식 : 소수점이 없는 숫자를 표현
            //int intValue = -100; //4바이트 크기의 정수
            //long longValue = 1234567890123L; //8바이트 크기의 정수, long 타입인걸 알려주기 위해 마지막에 L 적음

            //Console.WriteLine(intValue); //출력: -100
            //Console.WriteLine(longValue); //출력: 1234567890123

            ////부호 있는 정수 : 음수와 양수를 모두 표현 가능
            //sbyte signedByte = -50; //1바이트 크기
            //short signedShort = -32000; //2바이트 크기
            //int signedInt = -2000000; //4바이트 크기

            //Console.WriteLine(signedByte);
            //Console.WriteLine(signedShort);
            //Console.WriteLine(signedInt);

            ////부호 없는 정수 데이터 형식
            //byte unsignedByte = 255; //1바이트 크기
            //ushort unsignedShort = 65000; //2바이트 크기
            //uint unsignedInt = 4000000; //4바이트 크기
            //// 음수 쪽 크기를 양수 쪽으로 가져다 써 양수쪽 범위가 2배 커짐

            //Console.WriteLine(unsignedByte);
            //Console.WriteLine(unsignedShort);
            //Console.WriteLine(unsignedInt);

            ////실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f;  //단정밀도 실수
            //double doublePrecision = 3.1415926535;  //배정밀도 실수 (8바이트)
            //decimal highPrecision = 3.141592653545646546545m;   //고정밀도 실수 (16바이트), 마지막에 m을 붙인다.

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            ////접미사 사용 : 숫자의 데이터 형식을 명시
            //int integerValue = 100; //기본 정수형 int
            //long longValue = 100L;  // 정수형 long
            //float floatValue = 3.14f;   // 실수형 float
            //double doubleValue = 3.14;  // 기본 실수형 double
            //decimal decimalValue = 3.14m;   //고정밀도 실수형 decimal

            //Console.WriteLine(integerValue); //출력: 100
            //Console.WriteLine(longValue);   // 출력: 100
            //Console.WriteLine(floatValue);  // 출력: 3.14
            //Console.WriteLine(doubleValue); // 출력: 3.14
            //Console.WriteLine(decimalValue); // 출력: 3.14


            ////char 형식: 단일 문자를 표현
            //char letter = 'A'; //문자 'A' 저장
            //char symbol = '#'; //특수 기호 저장
            //char number = '9'; //숫자 형태의 문자 저장(문자 '9', 숫자 9 아님!!)

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            ////String 형식 : 여러 문자를 저장
            //string greeting = "Hello World"; //문자열 저장
            //string name = "Alice"; //이름 저장

            ///*Console.WriteLine(greeting); //출력 : Hello World
            //Console.WriteLine(name); //출력 : Alice*/

            //Console.Write(greeting + " ");
            //Console.Write(name);

            ////bool형식 : 참(true) = 1, 거짓(false) = 0

            //bool isRunning = true;  //프로그램 실행 상태
            //bool isFinished = false; //프로그램 종료 상태

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            ////const : 변하지 않는 값을 정의
            //const double Pi = 3.14159; //원주율
            //const int MaxScore = 100; //최대 점수

            //Console.WriteLine(Pi); //출력 : 3.14159
            //Console.WriteLine(MaxScore); //출력 : 100
            ////Pi = 3.14; //오류! 상수 값은 변경 불가능

            ////닷넷 형식 : 기본 형식의 닷넷 표현
            //System.Int32 number = 123;
            //System.String text = "Hello";
            //System.Boolean flag = true;

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);

            ////래퍼 : 기본 데이터 형식을 클래스 형태로 감싸서 객체로 취급할 수 있게 한다.
            ////int 래퍼 형식의 매서드 활용
            //int number = 123;

            //String numberAsString = number.ToString(); //정수를 문자열로 변환 ToString은 함수이기 때문에 () 필요!

            ////bool 래퍼형식
            //bool flag = true;

            //String flagAsString = flag.ToString(); //논리값을 문자열로 변환

            //Console.WriteLine(numberAsString);
            //Console.WriteLine(flagAsString);

        }
    }
}
