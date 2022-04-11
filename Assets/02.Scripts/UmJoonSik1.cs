using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UmJoonSik1 : MonoBehaviour
{
    public Event_Manager Event_Manager;
    public GameObject Frame;    //액자
    public Transform target;    //액자 따라갈 타겟
    public float speed = 5;     //스피드 5
    public GameObject Oem;  //엄글자
    public GameObject OemSpawn; //엄글자 스폰위치
    public AudioSource audiosourec;
    public AudioClip MainBGM;
    public GameObject Mini1;    //작은 액자1
    public GameObject Mini2;    //작은 액자2
    public GameObject Mini3;    //작은 액자3
    public GameObject Um1;  //엄1 이미지
    public GameObject Um2;  //엄2 이미지
    public GameObject Um3;  //엄3 이미지
    public GameObject eyeRiger; // 눈레이저
    public GameObject lefteyespawn; //왼쪽눈 스폰위치
    public GameObject Righteyespawn; // 오른쪽눈 스폰위치
    public GameObject Um3ball;  //볼
    public GameObject Um3ballSpawn;  //볼나오는 스폰위치
    public GameObject Um3ballSpawnUp1;  //윗쪽 볼나오는 스폰위치
    public GameObject Um3ballSpawnUp2;  //윗쪽 볼나오는 스폰위치
    public GameObject Upfloor;  //윗 바닥
    public GameObject Downfloor;
    public GameObject UmEvent;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Um());
        audiosourec.clip = MainBGM;
        Event_Manager = GameObject.Find("GameManager").GetComponent<Event_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Umtarget());
    }

    IEnumerator Umtarget()
    {
        yield return new WaitForSeconds(11f);

        //액자가 타겟을 따라감
        Frame.transform.position = Vector2.MoveTowards(new Vector2(Frame.transform.position.x, Frame.transform.position.y), new Vector2(target.position.x, target.position.y), speed * Time.deltaTime);
        //Mini1,2,3을 회전시킴
        Mini1.transform.Rotate(new Vector3(0f, 0f, 45f));
        Mini2.transform.Rotate(new Vector3(0f, 0f, 45f));
        Mini3.transform.Rotate(new Vector3(0f, 0f, 45f));
    }



    IEnumerator Um()
    {
        yield return new WaitForSeconds(0.2f);

        audiosourec.volume = 0f;

        Um1.SetActive(true);    //활성화

        Upfloor.SetActive(true);    //활성화
        Downfloor.SetActive(true);  //활성화

        yield return new WaitForSeconds(17f);    //딜레이 5초줌

        audiosourec.volume = 0.4f;

        Um1.SetActive(false);   //비활성화

        yield return new WaitForSeconds(1f);    //딜레이 1초줌

        Um2.SetActive(true);    //활성화

        yield return new WaitForSeconds(1f);    //딜레이 1초줌

        for (int i = 0; i < 5; i++)
        {
            GameObject a = Instantiate(Oem, OemSpawn.transform.position, OemSpawn.transform.rotation);  //클론생성
            Destroy(a, 4f); //클론 4초후 삭제
        }

        Um2.SetActive(false);   //비활성화

        yield return new WaitForSeconds(5f);    //딜레이 5초줌

        Um3.SetActive(true);    //활성화

        yield return new WaitForSeconds(1f);    //딜레이 1초줌

        GameObject b = Instantiate(eyeRiger, lefteyespawn.transform.position, lefteyespawn.transform.rotation); //클론생성
        GameObject c = Instantiate(eyeRiger, Righteyespawn.transform.position, Righteyespawn.transform.rotation); //클론생성
        Destroy(b, 5f); //5초후 삭제
        Destroy(c, 5f); //5초후 삭제

        yield return new WaitForSeconds(1f);    //딜레이 1초줌

        for(int i=0; i<4; i++)
        {
            Um3ballSpawn.transform.Rotate(new Vector3(0f, 0f, -5f));    //스폰위치를 돌림
            GameObject d = Instantiate(Um3ball, Um3ballSpawn.transform.position, Um3ballSpawn.transform.rotation);  //클론생성
            Destroy(d, 5f);
        }

        yield return new WaitForSeconds(1f);    //딜레이 1초줌

        for (int i = 0; i < 4; i++)
        {
            Um3ballSpawn.transform.Rotate(new Vector3(0f, 0f, 8f));    //스폰위치를 돌림
            GameObject d = Instantiate(Um3ball, Um3ballSpawn.transform.position, Um3ballSpawn.transform.rotation);  //클론생성
            Destroy(d, 5f);
        }

        yield return new WaitForSeconds(2f);    //딜레이 2초줌

        for (int i = 0; i < 4; i++)
        {
            Um3ballSpawn.transform.Rotate(new Vector3(0f, 0f, -98f));    //스폰위치를 돌림
            GameObject e = Instantiate(Um3ball, Um3ballSpawn.transform.position, Um3ballSpawn.transform.rotation);  //클론생성
            Destroy(e, 5f);
        }

        for (int i = 0; i < 4; i++)
        {
            Um3ballSpawn.transform.Rotate(new Vector3(0f, 0f, -98f));    //스폰위치를 돌림
            GameObject f = Instantiate(Um3ball, Um3ballSpawn.transform.position, Um3ballSpawn.transform.rotation);  //클론생성
            Destroy(f, 5f);
        }

        yield return new WaitForSeconds(5f);    //딜레이 5초줌

        Um3.SetActive(false);   //비활성화

        Upfloor.SetActive(false);   //비활성화
        Downfloor.SetActive(false); //비활성화
        yield return new WaitForSeconds(0.2f);
        Event_Manager.RandomEvent();
        yield return new WaitForSeconds(1f);
        UmEvent.SetActive(false);

    }
}
