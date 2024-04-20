namespace 클래스
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 왜 클래스라는 개념이 도입되었는가?

            // 조건문, 반복문, 배열.. -> 계산기, 간단한 미니게임을 쉽게 만들 수 있다.
            // ChatGpt Simple coupt game make me plz with C#

            // 조건문, 반복문을 하나의 코드 줄에서 반복하면.. 코드 줄 수가 너무 길어진다.
            // 기능을 추가 하려고 보면 그 긴 코드를 저부 다 확인을 해야한다.
            // 공통적인 기능을 하는 녀석을 묶어서 관리하고 싶어진거다.

            // 은행 이름-농협, 국민, 신한, 우리
            // 은행에 들어가있는 돈 money
            // 입금 , 출금

            // 농협이라는 은행, 국민 은행 2개 갖고 있다.

            string nhName = "농협";
            int nhmoney = 100;
            //

            string khName = "국민";
            int Khmoney = 100;
            // 클래스 : 객체를 변수와 메소드를 묶어서 표현하는 사용자 자료형
            // 클래스를 사용하는 이유?
            // 공통된 특징을 기진 데이터에 속성을 다르게 하여 기능을 표현을 하기 위해서 사용한다.

            Bank nhBank = new Bank("농협", 10000);
            //nhBank.name = "농협";
            //nhBank.money = 10000;
            nhBank.PrintInfo();

            Bank kbBank = new Bank("국민", 100000);
            //kbBank.name = "국민";
            //kbBank.money = 100000;
            kbBank.PrintInfo();

            생성자 myCalss = new 생성자("안녕하세요", 0.01f);

        }

        // 클래스 선언 : class 클래스 이름 {}

    }
}
