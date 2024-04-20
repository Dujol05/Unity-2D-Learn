using System.ComponentModel.DataAnnotations;

namespace 반복문
{
    internal class Program
    {
        // 반복문
        // 조건의 거짓이 될 때 까지 코드 블록 내부를 반복해서 실행
        // 종류 : for, while; do ~ while

        static void Main(string[] args)
        {
            // case 1. for 반복문
            // 반복문 왜 필요한가?
            // 1부터 1000000까지 숫자를 출력하고 싶다.

            // case 1. for 반복문
            // for(초기화식; 조건식; 증감식)
            // { }

            // Tip : 변수의 이름을 일괄적으로 한번에 변경하고 싶습니다.
            // Ctrl + R + R : 이름을 일괄적으로 변경해주는 단축키 바꾸고자 하는 이름의 앞에
            // 마우스 커서를 두고 단축키를 입력해주세요.
            for (int number = 0; number < 5; number++)
            {
                // 조건의 통과 되었을 때 아래의 코드 블록이 실행된다.
                Console.WriteLine($"출력될 숫자 {number}");
            }

            // case 2. 중첩 for 반복문
            for (int X = 1; X < 10; X++)
            {
                for (int y = 1; y < 10; y++)
                {
                    Console.WriteLine($"{X} x {y} = {X*y}");
                }

                // case 3. while 반복문
                // while(조건식) 참이면 계속 반복하는 녀석

                int whileNumber = 0;
                int whileSum = 0;
                while( whileNumber < 9 )
                {
                    int test = 10;

                    whileSum += whileNumber;
                    test++;

                    whileNumber++;
                    Console.WriteLine($"test : {test}");
                }
                Console.WriteLine(whileNumber);

                // case 4. do. while 반복문
                // 반드시 do문을 한번은 실행하고 while 조건물을 체크하는 녀석

                int doIndex = 0;

                do
                {
                    Console.WriteLine($"doIndex : {doIndex}");
                    doIndex++;

                }
                while (doIndex < 10);

                // case 5. 무한 바복문 -> 유니티가 멈추고 강제 종료가 되어버린다
                // 우리가 무한 반복문이 발생하지 않게 처리를 해야한다.

                //while (true)
                //{

                //}

                // case 6. 점프문 : 코드를 특정 위치로 이동시키는 명령문
                // break, continue, return, goto
                
                // break = whitch문과 같이 쓰이고, break를 만나면 해당 코드블록으로부터 빠져나간다.
                // continue = 반복문에 쓰이고, continue를 만나면 밤복문의 처음으로 돌아간다.
                // goto = 특정 레이블로 이동하는 명령문 -> 사용하기를 지양한다.
                // return = 메서드를 종료하고, 메서드를 호출한 곳으로 돌아가는 명령문
            }
        }
    }
}
