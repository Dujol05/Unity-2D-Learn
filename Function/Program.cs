using System.ComponentModel.Design;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 함수를 왜 쓰는가?

            // Console.WriteLine = 출력
            // 
            int a = 10;
            int b = 20;

            // 반항 값이 없는 함   수
            void start() { }
            void Updeta() { }
            // 반항 값이 있는 함수

            Console.WriteLine("Hello World");
            bool isboy = true;
            Console.WriteLine(isboy);

            // 동전의 앞면은 1, 동전의 뒷면은 0

            string mystring = Console.ReadLine();
            Console.WriteLine(mystring);
            int coinNumber = int.Parse(Console.ReadLine());
             
            
            // 주석 : 사람이 보는 것이기 때문에 설명을 담아둘 수 있다.
            // 연속으로 달아둘 수 있다.
            // Ctrl + k + c 일괄 주석 처리
            // Ctrl + k + u 일괄 주석 해제
            // 이동 하고 싶은 코드를 드래그 한 후 Alt를 누른 상태로 키보드 화살표 위 아래 사용
            if (coinNumber == 1)
            {
                Console.WriteLine("왼손으로 휘두르다");
            }
            else if (coinNumber == 0) 
            {
                Console.WriteLine("오른손으로 휘두르다");
            }

            // 두 수를 비교
            int front = 10;
            int after = 25;

            bool booltest = front > 25; //false
            bool isSame = 10 == 10;
            bool isSameAndBigger = 10 >= 15;

            var number = 100;
            var resultB = !(number < 20);

            // 함수의 문법

            // 반환 값 = 함수의 이름()
            // {
            //      코드 블럭
            //      실제로 코드를 확인하는 부분을 코드 블럭이라 한다. { 열렸으면 } 닫혀야 합니다. eof에러.
            // }

            // 반환 값....
            // 함수를 실행하고 나서 결과 값을 반환해주고 싶으면, void 대신 반환하고 싶은 데이터 타입(자료형)을 지어주면 된다.
            // 반환 값이 있는 함수는 반드시 해당 데이터를 coturn 해줘야 한다.


                void BooleanTypeAndOperator(int a, int b, int n)
            {
                if (a+b >= n)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
        }
    }
}
