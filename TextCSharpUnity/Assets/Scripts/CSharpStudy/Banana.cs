using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Fruit
{
    void InitData()
    {
        name = "�ٳ���";
        price = 5000;
        description = "�����";
    }
    // Start is called before the first frame update
    void Start()
    {
        InitData();
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
