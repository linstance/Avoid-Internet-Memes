using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Rupee : MonoBehaviour
{
    public Event_Manager Event_Manager;

    public float speed = 5f;    //스피드 5로 줌

    public Transform target1;   //타겟1넣을곳
    public Transform target2;   //타겟2넣을곳

    public GameObject pado1;    //파도 넣을곳
    public GameObject pado2;    //파도 넣을곳

    public GameObject padosen;  //파도 예측선 넣을곳

    public GameObject cim;  //침 넣을곳
    public GameObject cimsan;   //침 예측선 넣을곳

    public GameObject Rupee1;    //루피1이미지 넣을곳
    public GameObject Rupee2;   //루피2 이미지 넣을곳
    public GameObject RupeeEvent;   //루피 이벤트

    public GameObject RupeeAttack;  //루피 공격이미지 넣을곳
    public GameObject RupeeAttacksmoll; //루피 작은공격이미지
    public GameObject RupeeSpawn;   //루피 공격스폰

    public GameObject Up_bulletspawn;   //윗쪽 공격 스폰장소
    public GameObject Up_bulletspawn2;   //윗쪽 공격 스폰장소2
    public GameObject Up_bulletspawn3;  //윗쪽 공격 스폰장소3
    public GameObject Up_bulletspawn4;   //윗쪽 공격 스폰장소4
    public GameObject Up_bulletspawn5;  //윗쪽 공격 스폰장소5
    void Start()
    {
        StartCoroutine(RupeePaten());
        StartCoroutine(padoPaten());

        Event_Manager = GameObject.Find("GameManager").GetComponent<Event_Manager>();
    }

    void Update()
    {
        StartCoroutine(RupeePaten2());
    }
    IEnumerator RupeePaten()
    {
        Rupee1.SetActive(true); // 루피1 이미지 활성화

        yield return new WaitForSeconds(1f);    //딜레이 1초줌

        cimsan.SetActive(true);     //침 예측선 활성화

        yield return new WaitForSeconds(1f);    //딜레이 1초줌

        cimsan.SetActive(false);    // 침 예측선 비활성화

        yield return new WaitForSeconds(1.5f);  //딜레이 1.5초줌

        cim.SetActive(true);    //침 활성화

        yield return new WaitForSeconds(1.35f); //딜레이 1.35초줌

        cim.SetActive(false);   // 침 비활성화

        yield return new WaitForSeconds(1.5f);  //딜레이 1.5초줌

        cim.transform.position = new Vector3(0.6f, 0.20f);  //비활성화된 침을 원래자리로 되돌려놓음

    }
    IEnumerator RupeePaten2()
    { 
        yield return new WaitForSeconds(9f);    //딜레이 9초줌

        padosen.SetActive(false);      //파도예측선 비활성화

        yield return new WaitForSeconds(2f);    //딜레이 2초줌

        //pado들이 타셋을 쫒아감
        pado1.transform.position = Vector2.MoveTowards(new Vector2(pado1.transform.position.x, pado1.transform.position.y), new Vector2(target1.position.x, target1.position.y), speed * Time.deltaTime);
        pado2.transform.position = Vector2.MoveTowards(new Vector2(pado2.transform.position.x, pado2.transform.position.y), new Vector2(target2.position.x, target2.position.y), speed * Time.deltaTime);

        yield return new WaitForSeconds(4f);    //딜레이 4초줌

        pado1.SetActive(false);     //pado1을 비활성화
        pado2.SetActive(false);     //pado2을 비활성화

        pado1.transform.position = new Vector3(-7.5f, -1.4f, 0f);     //pado1을 원래 제자리로 놓음
        pado2.transform.position = new Vector3(7.5f, -1.4f, 0f);      //pado2을 원래 제자리로 놓음

        yield return new WaitForSeconds(1f);    //딜레이 1초줌

        Rupee1.SetActive(false);    //루피1이미지 비활성화

        yield return new WaitForSeconds(1f);
    }
    IEnumerator padoPaten()
        {
            yield return new WaitForSeconds(7f);    //딜레이 7초줌

            padosen.SetActive(true);    //파도예측선 활성화

            yield return new WaitForSeconds(3f);    //딜레이 3초줌

            pado1.SetActive(true);  //pado1을 활성화
            pado2.SetActive(true);  //pado2을 활성화

            yield return new WaitForSeconds(7f);    //딜레이 1초줌

            Rupee2.SetActive(true);     //루피2이미지 활성화

        yield return new WaitForSeconds(1f);

        RupeeAttack.SetActive(true);

        for (int i = 0; i <10; i++)
        {
            RupeeSpawn.transform.Rotate(new Vector3(0f, 0f, -140f));
            GameObject a = Instantiate(RupeeAttack, RupeeSpawn.transform.position, RupeeSpawn.transform.rotation);
            Destroy(a, 1f);
        }

        yield return new WaitForSeconds(1f);

        for (int i = 0; i < 4; i++)
        {
            RupeeSpawn.transform.Rotate(new Vector3(0f, 0f, -12f));
            GameObject a = Instantiate(RupeeAttack, RupeeSpawn.transform.position, RupeeSpawn.transform.rotation);
            Destroy(a, 1f);
        }

        yield return new WaitForSeconds(1f);

        for (int i = 0; i < 4; i++)
        {
            RupeeSpawn.transform.Rotate(new Vector3(0f, 0f, -10f));
            GameObject a = Instantiate(RupeeAttack, RupeeSpawn.transform.position, RupeeSpawn.transform.rotation);
            Destroy(a, 1f);
        }

        yield return new WaitForSeconds(1f);
    
        for (int i = 0; i < 4; i++)
        {
            RupeeSpawn.transform.Rotate(new Vector3(0f, 0f, -10f));
            GameObject a = Instantiate(RupeeAttack, RupeeSpawn.transform.position, RupeeSpawn.transform.rotation);
            Destroy(a, 1f);
        }

        yield return new WaitForSeconds(1f);

        for (int i = 0; i < 4; i++)
        {
            RupeeSpawn.transform.Rotate(new Vector3(0f, 0f, -10f));
            GameObject a = Instantiate(RupeeAttack, RupeeSpawn.transform.position, RupeeSpawn.transform.rotation);
            Destroy(a, 1f);
        }

        yield return new WaitForSeconds(1f);

        for (int i = 0; i < 4; i++)
        {
            RupeeSpawn.transform.Rotate(new Vector3(0f, 0f, -10f));
            GameObject a = Instantiate(RupeeAttack, RupeeSpawn.transform.position,RupeeSpawn.transform.rotation);
            Destroy(a, 1f);
        }

        yield return new WaitForSeconds(2f);

        for(int i = 0; i < 4; i++)
        {
            Up_bulletspawn.transform.Rotate(new Vector3(0f, 0f, 90f));
            GameObject b = Instantiate(RupeeAttacksmoll, Up_bulletspawn.transform.position, Quaternion.identity);
            Destroy(b,5f);
        }

        for (int i = 0; i < 4; i++)
        {
            Up_bulletspawn2.transform.Rotate(new Vector3(0f, 0f, 90f));
            GameObject c = Instantiate(RupeeAttacksmoll, Up_bulletspawn2.transform.position, Up_bulletspawn2.transform.rotation);
            Destroy(c, 5f);
        }

        for (int i = 0; i < 4; i++)
        {
            Up_bulletspawn3.transform.Rotate(new Vector3(0f, 0f, 90f));
            GameObject d = Instantiate(RupeeAttacksmoll, Up_bulletspawn3.transform.position, Up_bulletspawn3.transform.rotation);
            Destroy(d, 5f);
        }

        for (int i = 0; i < 4; i++)
        {
            Up_bulletspawn4.transform.Rotate(new Vector3(0f, 0f, 90f));
            GameObject e = Instantiate(RupeeAttacksmoll, Up_bulletspawn4.transform.position, Up_bulletspawn4.transform.rotation);
            Destroy(e, 5f);
        }

        for (int i = 0; i < 4; i++)
        {
            Up_bulletspawn5.transform.Rotate(new Vector3(0f, 0f, 90f));
            GameObject f = Instantiate(RupeeAttacksmoll, Up_bulletspawn5.transform.position, Up_bulletspawn5.transform.rotation);
            Destroy(f, 5f);
        }

        yield return new WaitForSeconds(3f);

        RupeeAttack.SetActive(false);

        yield return new WaitForSeconds(0.5f);

         Rupee2.SetActive(false);

        yield return new WaitForSeconds(0.2f);

        Event_Manager.RandomEvent();

        yield return new WaitForSeconds(1.0f);
        RupeeEvent.SetActive(false);
        }
}
