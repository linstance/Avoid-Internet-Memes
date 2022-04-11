using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalityLocation : MonoBehaviour
{
    private Transform myTransform; //자신의 위치
    public GameObject Personality; //인성문제 글자 넣을 곳

    public void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    //부딪쳤을때 발생할 이벤트
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Personality.SetActive(false);  //인성문제 글자 비활성화
        myTransform.position = Personality.transform.position;
    }
}
