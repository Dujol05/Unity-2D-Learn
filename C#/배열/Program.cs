namespace 배열
{
    internal class Program
    {
        // 배열?
        // 변수를 선언한 목적 : 데이터를 저장하고 사용하기 위해서.
        // 변수를 여러개 선언하는 것은 비효율적이다.
        // 같은 데이터 타입을 갖는 변수를 한번에 선언하기 위해서 사용하는 것이 배열이다.
        static void Main(string[] args)
        {
            // 1. 배열의 선언
            int number; // 변수 선언
            int[] intArray1; // 배열 선언

            // 2. 배열의 초기화 (처음 데이터를 할당).
            intArray1 = new int[3] { 1, 3, 5 };
            int[] intArray2 = new int[] { 10, 20, 30 };
            int[] intArray3 = {100, 200, 300};

            // 3. 배열의 사용. 장점 , 반복문이랑 함께 사용할 때 벗어난다.

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i}번째 배열 값 출력 : {intArray1[i]}");
            }

            // 4. 배열의 길이
            // 배열은 자신의 길이를 반환해준다.
            // 자신 배열 이름.Length

            // 5. 2차원 배열
            int[,] cell = new int[2, 3];
        }
    }
}
