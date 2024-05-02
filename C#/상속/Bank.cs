using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속
    // 상속의 기본 문법 Class 클래스명 : 상속하고자 하는 클래스 이름
{
    internal class Bank
    {
        // 접근 지정자를 통해서 외부에서 사용할 수 있는지 없는지 허락
        // private 나만 쓸거야, public 공용, protected 나 + 나를 상속한 녀석까지 허락
        protected string name;
        protected int money;
        // Bank 자식은 절대 쓰지 말고, Bank 내부에서만 쓸거야. -> private : 다른 클래스에서 변형이 되는 것을 원치
        // public 모두 다 선언. -> private, protected 바꾸려는 노력.
        public void Withdraw() { }
        public void Deposit() { }

        public void show()
        {
            Console.WriteLine($"Bank의 이름 : {name} \n Bank의 금액 : {money}");
        }

        public Bank() { }    // 기본 생성자

        public Bank(string name, int money)
        {
            this.name = name;
            this.money = money;
        } 
    }
    class CenterBank : Bank
    {
        // 공통적인 요소를 호출하게끔

        public string name;
        public int centerMoney;

        public void MakeMoney() { }

        // 클래스 내부 멤버 변수를 Console창에 보여주는 함수
        public void Show()
        {
            base.name = "부모의 이름";     // base, this키워드를 사용해서 부모의 변수인지 자신의 변수인지 판별
            this.name = "중앙 은행";
            money = 500000;
        }

        public CenterBank(string name, string parentName,int money, int centerMoney) : base(parentName, money)
        {
            this.name = name;
            this.centerMoney = money;
        }
    }
    // 중앙 은행 : 화폐를 만들어 낼 수 있는 기능
    // 지역 은행 : 돈을 입금, 인출
}
