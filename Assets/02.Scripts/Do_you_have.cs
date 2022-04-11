using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Do_you_have : MonoBehaviour
{
    public Event_Manager Event_Manager;

    public float speed = 5f;    //스피드 5로 줌
    public Transform target;    //개인주의 이미지가 따라갈 오브젝트
    public GameObject individualism1;// ㄱ 이미지 넣을 곳
    public GameObject individualism2;// ㅐ 이미지 넣을 곳
    public GameObject individualism3;// ㅇ 이미지 넣을 곳
    public GameObject individualism4;// ㅣ 이미지 넣을 곳
    public GameObject individualism5;// ㄴ 이미지 넣을 곳
    public GameObject individualism6;// ㅈ 이미지 넣을 곳
    public GameObject individualism7;// ㅜ 이미지 넣을 곳
    public GameObject individualism8;// ㅇ 이미지 넣을 곳
    public GameObject individualism9;// ㅡ 이미지 넣을 곳
    public GameObject individualism10;// ㅣ 이미지 넣을 곳
    public GameObject Personality1;//인성문제 글자 넣을 곳
    public GameObject Personality2;//인성문제 글자 넣을 곳
    public GameObject Personality3;//인성문제 글자 넣을 곳
    public GameObject Personality4;//인성문제 글자 넣을 곳
    public GameObject Personality1sen;  //인성문제 글자의 예측선 넣을곳
    public GameObject Personality2sen;  //인성문제 글자의 예측선 넣을곳
    public GameObject Personality3sen;  //인성문제 글자의 예측선 넣을곳
    public GameObject Personality4sen;  //인성문제 글자의 예측선 넣을곳
    public GameObject Personalitysafezone1; //인성문제 글자 세이프존;
    public GameObject Personalitysafezone2; //인성문제 글자 세이프존;
    public GameObject Personalitysafezone3; //인성문제 글자 세이프존;
    public GameObject Personalitysafezone4; //인성문제 글자 세이프존;
    public GameObject Personality_in;   //인
    public GameObject Personality_sao;//성
    public GameObject in_san;   // 인 예측선
    public GameObject sao_san; // 성 예측선
    public AudioSource  audioSource;  //메인bgm
    public AudioClip MainBGM;   //메인BGM
    public GameObject Lee_Geun_dae_Event;   //이근대위 이벤트 넣을 곳
    public GameObject Lee_Geun_dae1; //이근대위1 이미지 넣을 곳
    public GameObject Lee_Geun_dae2; // 이근대위2 이미지 넣을 곳

    bool isDoyouhave = false;

    void Start()
    {
       StartCoroutine(EndPaten());
        audioSource.clip = MainBGM;

        Event_Manager = GameObject.Find("GameManager").GetComponent<Event_Manager>();
    }

    void Update()
    {
        StartCoroutine(LeeGeundaePaten());
    }
    IEnumerator LeeGeundaePaten()
    {

        yield return new WaitForSeconds(4f);  //딜레이 4초 줌

        //ㄱ오브젝트가 플레이어를 따라가게하게함
        individualism1.transform.position = Vector2.MoveTowards(new Vector2(individualism1.transform.position.x, individualism1.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);

        yield return new WaitForSeconds(3f);  //딜레이 3초줌

        individualism1.SetActive(false);    //ㄱ오브젝트를 비활성화

        //ㅐ,ㅇ오브젝트가 플레이어를 따라가게하게함
        individualism2.transform.position = Vector2.MoveTowards(new Vector2(individualism2.transform.position.x, individualism2.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);
        individualism3.transform.position = Vector2.MoveTowards(new Vector2(individualism3.transform.position.x, individualism3.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);

        yield return new WaitForSeconds(3f);    //딜레이 3초줌

        individualism2.SetActive(false);    //ㅐ오브젝트를 비활성화
        individualism3.SetActive(false);    //ㅇ오브젝트를 비활성화

        //ㅣ,ㄴ,ㅈ오브젝트가 플레이어를 따라가게함
        individualism4.transform.position = Vector2.MoveTowards(new Vector2(individualism4.transform.position.x, individualism4.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);
        individualism5.transform.position = Vector2.MoveTowards(new Vector2(individualism5.transform.position.x, individualism5.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);
        individualism6.transform.position = Vector2.MoveTowards(new Vector2(individualism6.transform.position.x, individualism6.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);

        yield return new WaitForSeconds(3f);    //딜레이 3초줌

        individualism4.SetActive(false);    //ㅣ 오브젝트를 비활성화
        individualism5.SetActive(false);    //ㄴ 오브젝트를 비활성화
        individualism6.SetActive(false);    //ㅈ 오브젝트를 비활성화

        //ㅜ,ㅇ,ㅡ,ㅣ오브젝트가 플레이어를 따라가게함
        individualism7.transform.position = Vector2.MoveTowards(new Vector2(individualism7.transform.position.x, individualism7.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);
        individualism8.transform.position = Vector2.MoveTowards(new Vector2(individualism8.transform.position.x, individualism8.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);
        individualism9.transform.position = Vector2.MoveTowards(new Vector2(individualism9.transform.position.x, individualism9.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);
        individualism10.transform.position = Vector2.MoveTowards(new Vector2(individualism10.transform.position.x, individualism10.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);

        yield return new WaitForSeconds(3f);    //딜레이 3초줌

        individualism7.SetActive(false);    //ㅜ오브젝트를 비활성화
        individualism8.SetActive(false);    //ㅇ오브젝트를 비활성화
        individualism9.SetActive(false);    //ㅡ오브젝트를 비활성화
        individualism10.SetActive(false);   //ㅣ오브젝트를 비활성화

        individualism1.transform.position = new Vector3(-4.049438f, 0.9374164f, 0f);    //ㄱ오브젝트 처음 위치로 이동
        individualism2.transform.position = new Vector3(-2.823032f, 1.005882f , 0f);    //ㅐ오브젝트 처음 위치로 이동
        individualism3.transform.position = new Vector3(-1.586735f, 1.24062f, 0f);  //ㅇ오브젝트 처음 위치로 이동
        individualism4.transform.position = new Vector3(-0.3108771f, 0.7711438f, 0f);   //ㅣ오브젝트 처음 위치로 이동
        individualism5.transform.position = new Vector3(-0.39f, -0.07f, 0f);    //ㄴ오브젝트 처음 위치로 이동
        individualism6.transform.position = new Vector3(1.607856f, 0.9667588f, 0f); //ㅈ오브젝트 처음 위치로 이동
        individualism7.transform.position = new Vector3(1.686979f, -0.5394757f, 0f);    //ㅜ오브젝트 처음 위치로 이동
        individualism8.transform.position = new Vector3(3.85297f, 1.201497f, 0f);   //ㅇ오브젝트 처음 위치로 이동
        individualism9.transform.position = new Vector3(3.892532f, 0.3310105f, 0f); //ㅡ오브젝트 처음 위치로 이동
        individualism10.transform.position = new Vector3(5.089268f, 0.3310105f, 0f);    //ㅣ오브젝트 처음 위치로 이동
    }

        IEnumerator EndPaten()
    {


        yield return new WaitForSeconds(1f);

        Lee_Geun_dae1.SetActive(true);  //이근대위1 이미지 활성화

        yield return new WaitForSeconds(2f);    //딜레이 2초줌

        Lee_Geun_dae1.SetActive(false); //이근대위1 이미지 비활성화

        yield return new WaitForSeconds(0.2f);

        audioSource.volume = 0.1f;

        yield return new WaitForSeconds(1f);    //딜레이 1초줌

        // 개인주의 이미지 활성화시켜서 이미지를 보여줌
        individualism1.SetActive(true);     //ㄱ오브젝트를 활성화
            individualism2.SetActive(true);     //ㅐ오브젝트를 활성화 
            individualism3.SetActive(true);     //ㅇ오브젝트를 활성화
            individualism4.SetActive(true);     //ㅣ오브젝트를 활성화
            individualism5.SetActive(true);     //ㄴ오브젝트를 활성화
            individualism6.SetActive(true);     //ㅈ오브젝트를 활성화   
            individualism7.SetActive(true);     //ㅜ오브젝트를 활성화
            individualism8.SetActive(true);     //ㅇ오브젝트를 활성화 
            individualism9.SetActive(true);     //ㅡ오브젝트를 활성화  
            individualism10.SetActive(true);   //ㅣ오브젝트를 활성화 

        yield return new WaitForSeconds(13f);    //딜레이 13초줌

        yield return new WaitForSeconds(0.2f);

        audioSource.volume = 0.4f;

        Lee_Geun_dae2.SetActive(true);  //이근대위 이미지2 활성화

        yield return new WaitForSeconds(2f); //딜레이 1초줌

        Lee_Geun_dae2.SetActive(false); //이근대위 이미지2 비활성화

        yield return new WaitForSeconds(0.5f);    //딜레이 0.5초줌

        yield return new WaitForSeconds(1f); ;    //딜레이 1초줌

        Personality1sen.SetActive(true);    //인 오브젝트의 예측선 활성화
        Personality2sen.SetActive(true);    //성 오브젝트의 예측선 활성화
        Personality3sen.SetActive(true);    //문 오브젝트의 예측선 활성화
        Personality4sen.SetActive(true);    //제 오브젝트의 예측선 활성화

        yield return new WaitForSeconds(1.5f);  // 딜레이 1.5초 줌

        Personality1sen.SetActive(false);   //인 오브젝트의 예측선 비활성화
        Personality2sen.SetActive(false);   //성 오브젝트의 예측선 비활성화
        Personality3sen.SetActive(false);   //문 오브젝트의 예측선 비활성화
        Personality4sen.SetActive(false);   //제 오브젝트의 예측선 비활성화

        yield return new WaitForSeconds(0.5f); // 딜레이 0.5초 줌

        Personality1.SetActive(true);      //인 오브젝트 활성화
        Personality2.SetActive(true);      //성 오브젝트 활성화
        Personality3.SetActive(true);      //문 오브젝트 활성화
        Personality4.SetActive(true);      //제 오브젝트 활성화

        yield return new WaitForSeconds(1.15f);    //딜레이 1.15초 줌

        Personality1.SetActive(false);      //인 오브젝트 비활성화
        Personality2.SetActive(false);      //성 오브젝트 비활성화
        Personality3.SetActive(false);      //문 오브젝트 비활성화
        Personality4.SetActive(false);      //제 오브젝트 비활성화

        Personality1.transform.position = new Vector3(-4.739999f, 4f, 0f);
        Personality2.transform.position = new Vector3(-0.3399987f, 4f, 0f);
        Personality3.transform.position = new Vector3(4.660001f, 4f, 0f);
        Personality4.transform.position = new Vector3(9.06f, 4f, 0f);

        ///////////////////////////////////////////////////////
        ///
        yield return new WaitForSeconds(1f); ;    //딜레이 1초줌

        Personalitysafezone1.SetActive(true);    //인 오브젝트의 예측선 활성화
        Personalitysafezone2.SetActive(true);    //성 오브젝트의 예측선 활성화
        Personalitysafezone3.SetActive(true);    //문 오브젝트의 예측선 활성화
        Personalitysafezone4.SetActive(true);    //제 오브젝트의 예측선 활성화

        yield return new WaitForSeconds(1.5f);  // 딜레이 1.5초 줌

        Personalitysafezone1.SetActive(false);   //인 오브젝트의 예측선 비활성화
        Personalitysafezone2.SetActive(false);   //성 오브젝트의 예측선 비활성화
        Personalitysafezone3.SetActive(false);   //문 오브젝트의 예측선 비활성화
        Personalitysafezone4.SetActive(false);   //제 오브젝트의 예측선 비활성화

        yield return new WaitForSeconds(0.5f); // 딜레이 0.5초 줌

        Personality1.SetActive(true);      //인 오브젝트 활성화
        Personality2.SetActive(true);      //성 오브젝트 활성화
        Personality3.SetActive(true);      //문 오브젝트 활성화
        Personality4.SetActive(true);      //제 오브젝트 활성화

        yield return new WaitForSeconds(1.15f);    //딜레이 1.15초 줌

        Personality1.SetActive(false);      //인 오브젝트 비활성화
        Personality2.SetActive(false);      //성 오브젝트 비활성화
        Personality3.SetActive(false);      //문 오브젝트 비활성화
        Personality4.SetActive(false);      //제 오브젝트 비활성화

        Personality1.transform.position = new Vector3(-6.9f, 4f, 0f);
        Personality2.transform.position = new Vector3(-2.5f, 4f, 0f);
        Personality3.transform.position = new Vector3(2.5f, 4f, 0f);
        Personality4.transform.position = new Vector3(6.9f, 4f, 0f);

        ///////////////////////////////////////////////////////
        ///
        yield return new WaitForSeconds(1f); ;    //딜레이 1초줌

        Personality1sen.SetActive(true);    //인 오브젝트의 예측선 활성화
        Personality2sen.SetActive(true);    //성 오브젝트의 예측선 활성화
        Personality3sen.SetActive(true);    //문 오브젝트의 예측선 활성화
        Personality4sen.SetActive(true);    //제 오브젝트의 예측선 활성화

        yield return new WaitForSeconds(1.5f);  // 딜레이 1.5초 줌

        Personality1sen.SetActive(false);   //인 오브젝트의 예측선 비활성화
        Personality2sen.SetActive(false);   //성 오브젝트의 예측선 비활성화
        Personality3sen.SetActive(false);   //문 오브젝트의 예측선 비활성화
        Personality4sen.SetActive(false);   //제 오브젝트의 예측선 비활성화

        yield return new WaitForSeconds(0.5f); // 딜레이 0.5초 줌

        Personality1.SetActive(true);      //인 오브젝트 활성화
        Personality2.SetActive(true);      //성 오브젝트 활성화
        Personality3.SetActive(true);      //문 오브젝트 활성화
        Personality4.SetActive(true);      //제 오브젝트 활성화

        yield return new WaitForSeconds(1.15f);    //딜레이 1.15초 줌

        Personality1.SetActive(false);      //인 오브젝트 비활성화
        Personality2.SetActive(false);      //성 오브젝트 비활성화
        Personality3.SetActive(false);      //문 오브젝트 비활성화
        Personality4.SetActive(false);      //제 오브젝트 비활성화

        Personality1.transform.position = new Vector3(-8.950001f, 4f, 0f);
        Personality2.transform.position = new Vector3(-4.55f, 4f, 0f);
        Personality3.transform.position = new Vector3(0.4499998f, 4f, 0f);
        Personality4.transform.position = new Vector3(4.85f, 4f, 0f);

        ///////////////////////////////////////////////////////
        ///
        yield return new WaitForSeconds(1f); ;    //딜레이 1초줌

        Personalitysafezone1.SetActive(true);    //인 오브젝트의 예측선 활성화
        Personalitysafezone2.SetActive(true);    //성 오브젝트의 예측선 활성화
        Personalitysafezone3.SetActive(true);    //문 오브젝트의 예측선 활성화
        Personalitysafezone4.SetActive(true);    //제 오브젝트의 예측선 활성화

        yield return new WaitForSeconds(1.5f);  // 딜레이 1.5초 줌

        Personalitysafezone1.SetActive(false);   //인 오브젝트의 예측선 비활성화
        Personalitysafezone2.SetActive(false);   //성 오브젝트의 예측선 비활성화
        Personalitysafezone3.SetActive(false);   //문 오브젝트의 예측선 비활성화
        Personalitysafezone4.SetActive(false);   //제 오브젝트의 예측선 비활성화

        yield return new WaitForSeconds(0.5f); // 딜레이 0.5초 줌

        Personality1.SetActive(true);      //인 오브젝트 활성화
        Personality2.SetActive(true);      //성 오브젝트 활성화
        Personality3.SetActive(true);      //문 오브젝트 활성화
        Personality4.SetActive(true);      //제 오브젝트 활성화

        yield return new WaitForSeconds(1.15f);    //딜레이 1.15초 줌

        Personality1.SetActive(false);      //인 오브젝트 비활성화
        Personality2.SetActive(false);      //성 오브젝트 비활성화
        Personality3.SetActive(false);      //문 오브젝트 비활성화
        Personality4.SetActive(false);      //제 오브젝트 비활성화

        Personality1.transform.position = new Vector3(-6.9f, 4f, 0f);
        Personality2.transform.position = new Vector3(-2.5f, 4f, 0f);
        Personality3.transform.position = new Vector3(2.5f, 4f, 0f);
        Personality4.transform.position = new Vector3(6.9f, 4f, 0f);

        ///////////////////////////////////////////////////////
        ///
        yield return new WaitForSeconds(1f); ;    //딜레이 1초줌

        Personality1sen.SetActive(true);    //인 오브젝트의 예측선 활성화
        Personality2sen.SetActive(true);    //성 오브젝트의 예측선 활성화
        Personality3sen.SetActive(true);    //문 오브젝트의 예측선 활성화
        Personality4sen.SetActive(true);    //제 오브젝트의 예측선 활성화

        yield return new WaitForSeconds(1.5f);  // 딜레이 1.5초 줌

        Personality1sen.SetActive(false);   //인 오브젝트의 예측선 비활성화
        Personality2sen.SetActive(false);   //성 오브젝트의 예측선 비활성화
        Personality3sen.SetActive(false);   //문 오브젝트의 예측선 비활성화
        Personality4sen.SetActive(false);   //제 오브젝트의 예측선 비활성화

        yield return new WaitForSeconds(0.5f); // 딜레이 0.5초 줌

        Personality1.SetActive(true);      //인 오브젝트 활성화
        Personality2.SetActive(true);      //성 오브젝트 활성화
        Personality3.SetActive(true);      //문 오브젝트 활성화
        Personality4.SetActive(true);      //제 오브젝트 활성화

        yield return new WaitForSeconds(1.15f);    //딜레이 1.15초 줌

        Personality1.SetActive(false);      //인 오브젝트 비활성화
        Personality2.SetActive(false);      //성 오브젝트 비활성화
        Personality3.SetActive(false);      //문 오브젝트 비활성화
        Personality4.SetActive(false);      //제 오브젝트 비활성화

        Personality1.transform.position = new Vector3(-6.9f, 4f, 0f);
        Personality2.transform.position = new Vector3(-2.5f, 4f, 0f);
        Personality3.transform.position = new Vector3(2.5f, 4f, 0f);
        Personality4.transform.position = new Vector3(6.9f, 4f, 0f);

        yield return new WaitForSeconds(1f);

        in_san.SetActive(true);

        yield return new WaitForSeconds(1f);

        in_san.SetActive(false);

        yield return new WaitForSeconds(2f);

        Personality_in.SetActive(true);

        yield return new WaitForSeconds(3f);

        Personality_in.SetActive(false);

        yield return new WaitForSeconds(1f);

        sao_san.SetActive(true);

        yield return new WaitForSeconds(1f);

        sao_san.SetActive(false);

        yield return new WaitForSeconds(2f);

        Personality_sao.SetActive(true);

        yield return new WaitForSeconds(3f);

        Personality_sao.SetActive(false);

        yield return new WaitForSeconds(0.2f);

        Event_Manager.RandomEvent();

        yield return new WaitForSeconds(1.0f);
        Lee_Geun_dae_Event.SetActive(false);
    }
}