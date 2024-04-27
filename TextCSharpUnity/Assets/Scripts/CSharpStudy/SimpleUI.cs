using System;
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
    public TextMeshProUGUI Timetext;

    int currentDday = 1;
    string curretItem = "롱소드";
    int result = 1000;

    float seconds;
    float minutes;
    float hours;

    // Start is called before the first frame update
    void Start()                      // 게임이 시작하고 한번만 실행되는 이벤트 함수
    {
        NextDday(9);
        DdayText.text = "D-day" + " " + currentDday;
        DdayTextValue.text = "1";
        ItemInfoText.text = curretItem;
        ResultText.text = "금일 결과 " + result + "원";
    }

    // Update is called once per frame
    void Update()   // 계속 변경되는 함수를 적용해주는 함수
    {
        FlowTime();

        Timetext.text = $"{hours} : {minutes} : {seconds}";
    }

    void NextDday(int time)
    {
        currentDday = currentDday + time;
    } 

    void FlowTime()
    {
        seconds += Time.deltaTime; // 일정 시간 마다 시간을 더해준다.

        // seconds가 60초가 되면 minutes를 1증가 시키고 seconds가 0이 되도록 변경해주는 코드.
        // if~

        // minutes가 60분이 되면 hours를 1증가 시키고 minutes가 0이 되도록 변경해주는 코드.

        if (minutes >= 60)
        {
            hours++;
            minutes = 0;
        }
        if (seconds >= 60)
        {
            seconds++;
            minutes++;
            seconds = 0;
        }

        Debug.Log($"현재 초 : {hours} : {minutes} : {seconds}");
    }
} 