using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상화
{
    // 추상 클래스는 자체로는 객체화 할 수 없다.
    // 상속을 위한 목적으로 생성된 클래스이며,
    // abstract 클래스를 상속받는 자식 클래스들이 반드시 가져야 할 기능, 속성을 알려준다.
    internal class 추상클래스
    {
    }

    abstract class Car
    {
        // abstract 키워드를 선언해서, Car를 상속하는 녀석이 반드시 구현해야할 클래스를 지정해줄수 있다.
        // 단기간에 큰 영향을 주지 않지만
        // 규모가 큰 협업을 하거나, 3달 뒤에 이 클래스를 다시 볼때,, 클래스의 기능을 강제하기 때문에
        // 설계 단계에서 에러를 조정할 수 있다.

        protected abstract void SpeedUp();
        protected abstract void SpeedDown();

        public void Show()
        {

        }
    }

    class Truck : Car
    {
        protected override void SpeedDown()
        {
            
        }

        protected override void SpeedUp()
        {
            
        }
    }
}
