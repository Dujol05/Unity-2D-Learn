using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 다형성;

namespace 다형성
{
    class Worker
    {
        public void CareAnimal(Animal animal) // 동물들을 케어해주는 기능 동물이 100개면??
        {

            // 동물을 돌봐준다.
            animal.HP = animal.HP + 10;
        }

        public void Function(Animal animal)
        { 
            // 동물은 각자 동물이면서, 호랑이 일수도 있고, 독수리 일수도 있고, 상어 일수도 있다.
            
            // (Animal -> 각자의 클래스 변환)
            // as 키워드, is 키워드

            // is 앞에 데이터 타입과 is 뒤의 데이터 타입이 같으면 True 반환, 다르면 false 반환
            if (animal is Animal_Tiger)
            {
                Console.WriteLine("호랑이 입니다.");
            }
            else if (animal is Animal_Eagle)
            {
                Console.WriteLine("독수리 입니다.");
            }
            else if (animal is Animal_Shark)
            {
                Console.WriteLine("상어 입니다.");
            }
            else
            {
                Console.WriteLine("해당 하는 동물이 없습니다.");
            }
            // animal이 Animal_Tiger타입이면 해당 타입을 
        }
    }


    internal class Animal
    {
        public int HP;
    }

    class Animal_Tiger : Animal
    {
        void Run() { }
    }

    class Animal_Shark : Animal
    {
        void Swim() { }
    }

    class Animal_Eagle : Animal
    {
        void Fly() { }

    }
}
