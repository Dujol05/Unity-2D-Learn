using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스
{
    internal class 생성자
    {
        public string name;
        public float time;

        public 생성자()
        {

        }

        public 생성자(string name, float time) // (name)은 외부에서 데이터 받은 후 저장하는 지역변수
        {
            // this 키보워 : this는 자기 자신의 클래스를 의미하며,
            // 매개변수와 멤버변수의 이름이 같을 때 구분하기 위한 목전으로 사용.
            // 본인 클래스를 매개 변수로 사용하기 위해서도 사용.
            this.name = name;
            this.time = time;
        }
    }
}
