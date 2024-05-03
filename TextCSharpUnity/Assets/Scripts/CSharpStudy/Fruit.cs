using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Fruit : Goods
{
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI DescriptionText;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        NameText.text = $"과일의 이름 : {name}";
        DescriptionText.text = $"상품설명 : {description}";
        priceText.text = $"과일 가격 : {price}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public interface IExpired
{
    void Roted(); // 과일이 썩었다.
}
