using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndertakerBoysPetan : MonoBehaviour
{
    public Event_Manager Event_Manager;

    public Transform GwanSpwanPoint_01 = null;  //관을 스폰할 1번째 위치
    public Transform GwanSpwanPoint_02 = null;  //관을 스폰할 2번째 위치
    public Transform GwanSpwanPoint_03 = null;  //관을 스폰할 3번째 위치
    public Transform GwanSpwanPoint_04 = null;  //관을 스폰할 4번째 위치
    public Transform GwanSpwanPoint_05 = null;  //관을 스폰할 5번째 위치
    public Transform GwanSpwanPoint_06 = null;  //관을 스폰할 6번째 위치
    public Transform GwanSpwanPoint_07 = null;  //관을 스폰할 7번째 위치

    public Transform RunGwan_RightTransform = null; // 오른쪽에서 달려나가는 관을 생성할 위치
    public Transform RunGwan_LeftTransform = null;  // 왼쪽에서 달려나갈 관을 생성하는 위치

    public GameObject backGroundUndertakerBoys = null;  //관짝소년단 배경오브젝트

    public GameObject Gwan = null;  // 플레이어에게 부딪혀 데미지를 입힐 오브젝트
    public GameObject predictionLine = null; //예측선 

    public GameObject RunGwan_Left = null;  //왼쪽에서 달리는 관
    public GameObject RunGwan_Right = null; //오른쪽에서 달리는 관

    public GameObject UndertakerBoysPetans = null;  // 마지막에 false 로전환할 오브젝트

    public AudioSource audiosource;
    public AudioClip MainBGM;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UndertakerPetan());
        audiosource.clip = MainBGM;

        Event_Manager = GameObject.Find("GameManager").GetComponent<Event_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

     IEnumerator UndertakerPetan()
    {
        audiosource.volume = 0f;

        backGroundUndertakerBoys.SetActive(true);
        predictionLine.SetActive(true);

        yield return new WaitForSeconds(0.7f);

        predictionLine.SetActive(false);

        Instantiate(Gwan, GwanSpwanPoint_01);
            Instantiate(Gwan, GwanSpwanPoint_03);
            Instantiate(Gwan, GwanSpwanPoint_05);
            Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);
        
            Instantiate(Gwan, GwanSpwanPoint_02);
            Instantiate(Gwan, GwanSpwanPoint_04);
            Instantiate(Gwan, GwanSpwanPoint_06);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_06);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_06);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_06);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_06);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_06);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_06);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_06);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_06);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_06);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_06);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_06);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_06);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_06);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Gwan, GwanSpwanPoint_01);
        Instantiate(Gwan, GwanSpwanPoint_02);
        Instantiate(Gwan, GwanSpwanPoint_03);
        Instantiate(Gwan, GwanSpwanPoint_04);
        Instantiate(Gwan, GwanSpwanPoint_05);
        Instantiate(Gwan, GwanSpwanPoint_06);
        Instantiate(Gwan, GwanSpwanPoint_07);

        yield return new WaitForSeconds(0.7f);

        predictionLine.SetActive(true);
        backGroundUndertakerBoys.SetActive(false);
        yield return new WaitForSeconds(0.7f);

        predictionLine.SetActive(false);
        Instantiate(RunGwan_Left, RunGwan_LeftTransform);
        
        yield return new WaitForSeconds(4f);

        Instantiate(RunGwan_Right, RunGwan_RightTransform);

        yield return new WaitForSeconds(4.5f);

        audiosource.volume = 0.4f;

        yield return new WaitForSeconds(0.2f);

        Event_Manager.RandomEvent();

        yield return new WaitForSeconds(1.0f);

        UndertakerBoysPetans.SetActive(false);

       

    }
}
