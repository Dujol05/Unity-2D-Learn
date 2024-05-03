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
        NameText.text = $"������ �̸� : {name}";
        DescriptionText.text = $"��ǰ���� : {description}";
        priceText.text = $"���� ���� : {price}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public interface IExpired
{
    void Roted(); // ������ �����.
}
