using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmFrameTrigger : MonoBehaviour
{
    public GameObject Frame;    //액자 
    public GameObject[] Mini;   //작은 액자

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReturnFrame();
    }
    //충돌후 이벤트 발생
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Frame")    //게임오브젝트 이름이 Frame인 것만 충돌
        {
            Frame.SetActive(false);     //액자 비활성화
            Mini[0].SetActive(true);    //작은1 액자 활성화
            Mini[1].SetActive(true);    //작은2 액자 활성화
            Mini[2].SetActive(true);    //작은3 액자 활성화
        }
    }
    public void ReturnFrame()
    {
        if (Frame.activeSelf == false)
        {
            Frame.transform.localPosition = new Vector3(0f, 0f, 0f);    //액자 제자리로 이동
        }
    }
}
