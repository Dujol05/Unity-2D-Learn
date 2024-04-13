using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace dujol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수의 선언
            int myint;

            // 변수의 할당
            myint = 10;

            // 실수형
            //float mypioat = 3.14f;

            // 문자열
            //string mystring = "Hello World";

            // +, -, *, /

            int number1 = 10;
            int number2 = 20;

            int sum;
            sum = number1 + number2;
            string resuit = "두 수를 더한 값" + " ";

            Console.WriteLine(resuit + (number1 + number2));
            Console.WriteLine(resuit + number1);
            Console.WriteLine(resuit + number1 + number2);

            int sub;
            sub = number1 - number2;
            //Console.WriteLine(resuit + number1 - number2);

            int multi;
            multi = number1 * number2;
            Console.WriteLine(multi);

            int a = 10;
            int b = 20;
            int c = 3;
            int resultA = (a + b) / c;
            Console.WriteLine("a와 b를 더한 값을 c로 나눈 결과" + resultA);

        }
    }
}
