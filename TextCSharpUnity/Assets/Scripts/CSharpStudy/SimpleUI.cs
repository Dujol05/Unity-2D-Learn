using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SimpleUI : MonoBehaviour
{ 
    public TextMeshProUGUI DdayText;
    public TextMeshProUGUI DdayTextValue;
    public TextMeshProUGUI ItemInfoText;
    public TextMeshProUGUI ResultText;

    int currentDday = 1;
    string curretItem = "�ռҵ�";
    int result = 1000;
    float seconds;

    // Start is called before the first frame update
    void Start()                      // ������ �����ϰ� �ѹ��� ����Ǵ� �̺�Ʈ �Լ�
    {
        NextDday(9);
        DdayText.text = "D-day" + " " + currentDday;
        DdayTextValue.text = "1";
        ItemInfoText.text = curretItem;
        ResultText.text = "���� ��� " + result + "��";
    }

    // Update is called once per frame
    void Update()   // ��� ����Ǵ� �Լ��� �������ִ� �Լ�
    {
        
    }

    void NextDday(int time)
    {
        currentDday = currentDday + time;
    } 

    void FlowTime()
    {
        seconds += Time.deltaTime; // ���� �ð� ���� �ð��� �����ش�.
        Debug.Log($"���� �� : {seconds}");

        // seconds�� 60�ʰ� �Ǹ� minutes�� 1���� ��Ű�� seconds 
    }
}
