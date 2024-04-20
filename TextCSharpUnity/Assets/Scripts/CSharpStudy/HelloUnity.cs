using UnityEngine;
using TMPro;

public class HelloUnity : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;  // 데이터 타입인지 모르겠지만 뭔가를 사용하기 위해서 text이름의 변수로 저장하겠다.

    int damage = 100;           // 정수 값
    float time = 30.5f;         // 실수 값
    string name = "이순신";     // 문자열 값

    private void Start() // 게임 시작 후 한번만 실행 한다.
    {
        Debug.Log("데미지의 값" + damage);   
        Debug.Log("시간의 값" + time);      
        Debug.Log("이름" +name);


        text.text = string.Format($"Only{damage} English{time} is visible : 정말이니 ?"); // 배우지 않은게 많다.
    }


}
