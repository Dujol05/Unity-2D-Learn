using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit, IExpired
{
    void InitData()
    {
        name = "���";
        price = 1000;
        description = "������";
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
        description += "\n�� ������ ���� �� �ֽ��ϴ�.";
    }
}
