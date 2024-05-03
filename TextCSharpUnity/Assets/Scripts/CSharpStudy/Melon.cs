using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : Fruit
{
    void InitData()
    {
        name = "¸á·Ð";
        price = 10000;
        description = "¿¬µÎ»ö";
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
