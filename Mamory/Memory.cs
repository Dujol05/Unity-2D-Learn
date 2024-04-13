using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    internal class Memory
    {

        class Memory

        {  
            public int value = 10;
            public string name = "홍길동";
            public int attack = 100;
            public float attackRange = 3.14f;


            public void AddValue(int _value)
            {
                value = _value + this.value;
            }
        }
    }
}
