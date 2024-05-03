using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit, IExpired
{
    void InitData()
    {
        name = "사과";
        price = 1000;
        description = "빨갛다";
    }
    // Start is called before the first frame update
    protected override void Start()
    {
        InitData();
        Roted();
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Roted()
    {
        description += "\n이 과일을 썩을 수 있습니다.";
    }
}
