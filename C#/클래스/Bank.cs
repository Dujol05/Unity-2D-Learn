using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스
{
    internal class Bank
    {
        // 멤버 변수 : 같은 클래스에 소속된 메소드(함수) 이 함수를 공용으로 사용할 수 있다.
        // 생성하고 싶은 멤버 변수를 전부 드래그인 

        public string name;
        public int money;

        public Bank(string name, int money)
        {
            this.name = name;
            this.money = money;
        }

        public Bank()
        {

        }
        // 소멸자 : 객체가 소멸될 때 호출되는 메소드
        ~Bank()
        {

        }

        // 접근 지정자
        // public    : 외부에서 클래스를 통해 접근을 허용한다.
        // private   : 외부에서 클래스 접근을 허용하지 않고, 자식 클래스에도 접근 불가능
        // erotected : 외부에서 클래스 접근을 허용하지 않고, 자식 클래스에도 접근을 허용

        // 접근 지정자를 왜 사용 하는가?
        // 기능을 제한하는 것도 한 가지 가능.
        // 사람은 항상 실수를 할 수 있다. 사람이 할 수 있는 실수를 원칙적으로 막고 싶어요.
        // 기능을 제한하는 기능을 구현하면 실수를 막을 수 있다. 



        public void Deposit(int depositMoney)
        {
            money = money + depositMoney;
        }

        public void Withdraw(int withdrawMoney)
        {
            if (money < withdrawMoney)
            {
                Console.WriteLine("통장 잔고보다 큰 금액을 인출하려고 했습니다.");
                return;


            }

            money = money - withdrawMoney;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{name}에 {money}원이 들어 있습니다.");
        }

        public override bool Equals(object? obj)
        {
            return obj is Bank bank &&
                   name == bank.name &&
                   money == bank.money;
        }
    }
}
