using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShimYoungPetan : MonoBehaviour
{
    public Event_Manager Event_Manager;

    public GameObject ShimYoungPetans;

    public GameObject [] ShimYoungFloor = new GameObject[5];    // 이벤트 시작시 생성될 게임오브젝트를 가지고 있는 배열
    public GameObject [] ShimYoungSan = new GameObject[8];  // 총알 발사전 플레이어 에계 경고하기 위한 예측선을 담고 있는 배열
    public GameObject DocterImage = null;    // 의사양반의 배경을 담을 변수
    public GameObject Bullet = null;    //  의사양반이 발사할 총알을 담고 있는 변수

    public GameObject Chili = null;    // 심영이 떨어 뜨릴 고추
    public GameObject [] Egg = new GameObject[3];  // 심영의 부서질....
    public GameObject [] DestroyedEgg = new GameObject[3];  // 파괴된 심영의,,,,
    public GameObject ShimYoung = null; // 심영의 배경을 담고 있는 변수
    
    public Transform [] Bullet_Spawn = new Transform[8];    // 총알을 스폰할 위치값을 가진 배열
    public Transform [] Chili_Spawn_Spawn = new Transform[10];    // 고추를 스폰할 위치를 가지고 있는 배열

    public BrokenEgg_01 brokenEgg01;
    public BrokenEgg_02 brokenEgg02;

    public AudioSource audiosource;
    public AudioClip MainBGM;

    void Start()
    {
        StartCoroutine(ShimYoungEvent());
        audiosource.clip = MainBGM;
        Event_Manager = GameObject.Find("GameManager").GetComponent<Event_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EggShoot01()
    {
        brokenEgg01.Shoot01();
    }

    void EggShoot02()
    {
        brokenEgg02.Shoot02();
    }


    IEnumerator ShimYoungEvent()
    {

        audiosource.volume = 0.2f;

        DocterImage.SetActive(true);    // 의사양반 벼경 활성화
        ShimYoungFloor[1].SetActive(true);  //  발판1번 활성화
        ShimYoungFloor[2].SetActive(true);  //  발판2번 활성화
        ShimYoungFloor[3].SetActive(true);  //  발판3번 활성화
        ShimYoungFloor[4].SetActive(true);  //  발판4번 활성화

        yield return new WaitForSeconds(6.0f);

        ShimYoungSan[1].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[1]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[1].SetActive(false);
        ShimYoungSan[2].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[2]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[2].SetActive(false);
        ShimYoungSan[3].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[3]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[3].SetActive(false);
        ShimYoungSan[4].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[4]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[4].SetActive(false);
        ShimYoungSan[5].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[5]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[5].SetActive(false);
        ShimYoungSan[6].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[6]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[6].SetActive(false);
        ShimYoungSan[7].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        ShimYoungSan[7].SetActive(false);
        Instantiate(Bullet, Bullet_Spawn[7]);

        yield return new WaitForSeconds(3f);  //여기서 부터  반대로 발사

        ShimYoungSan[7].SetActive(true);
        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[7]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[7].SetActive(false);
        ShimYoungSan[6].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[6]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[6].SetActive(false);
        ShimYoungSan[5].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[5]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[5].SetActive(false);
        ShimYoungSan[4].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[4]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[4].SetActive(false);
        ShimYoungSan[3].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[3]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[3].SetActive(false);
        ShimYoungSan[2].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[2]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[2].SetActive(false);
        ShimYoungSan[1].SetActive(true);

        yield return new WaitForSeconds(0.3f);
        Instantiate(Bullet, Bullet_Spawn[1]);
        yield return new WaitForSeconds(0.2f);
        ShimYoungSan[1].SetActive(false);

        yield return new WaitForSeconds(3f);

        audiosource.volume = 0.4f;

        DocterImage.SetActive(false);    // 의사양반 배경 비활성화
        ShimYoungFloor[1].SetActive(false);  //  발판1번 비활성화
        ShimYoungFloor[2].SetActive(false);  //  발판2번 비활성화
        ShimYoungFloor[3].SetActive(false);  //  발판3번 비활성화
        ShimYoungFloor[4].SetActive(false);  //  발판4번 비활성화

        yield return new WaitForSeconds(1f);
        ShimYoung.SetActive(true);
        Egg[1].SetActive(true);
        Egg[2].SetActive(true);

        yield return new WaitForSeconds(0.5f);
        Egg[1].SetActive(false);
        Egg[2].SetActive(false);

        yield return new WaitForSeconds(0.1f);
        DestroyedEgg[1].SetActive(true);
        DestroyedEgg[2].SetActive(true);
        Invoke("EggShoot01", 1);
        Invoke("EggShoot02", 1);

        yield return new WaitForSeconds(1f);
        Invoke("EggShoot01", 1);
        yield return new WaitForSeconds(1f);
        Invoke("EggShoot02", 1);
        yield return new WaitForSeconds(1f);
        Invoke("EggShoot01", 1);
        Invoke("EggShoot02", 1);
        yield return new WaitForSeconds(2f);
        DestroyedEgg[1].SetActive(false);
        DestroyedEgg[2].SetActive(false);
        ShimYoung.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        Instantiate(Chili, Chili_Spawn_Spawn[1]);
        Instantiate(Chili, Chili_Spawn_Spawn[2]);
        Instantiate(Chili, Chili_Spawn_Spawn[3]);
        Instantiate(Chili, Chili_Spawn_Spawn[4]);
        Instantiate(Chili, Chili_Spawn_Spawn[5]);
        Instantiate(Chili, Chili_Spawn_Spawn[6]);
        Instantiate(Chili, Chili_Spawn_Spawn[7]);
        Instantiate(Chili, Chili_Spawn_Spawn[8]);
        Instantiate(Chili, Chili_Spawn_Spawn[9]);
        yield return new WaitForSeconds(1.0f);
        Instantiate(Chili, Chili_Spawn_Spawn[2]);
        Instantiate(Chili, Chili_Spawn_Spawn[4]);
        Instantiate(Chili, Chili_Spawn_Spawn[6]);
        Instantiate(Chili, Chili_Spawn_Spawn[8]);
        yield return new WaitForSeconds(1.0f);
        Instantiate(Chili, Chili_Spawn_Spawn[1]);
        Instantiate(Chili, Chili_Spawn_Spawn[3]);
        Instantiate(Chili, Chili_Spawn_Spawn[5]);
        Instantiate(Chili, Chili_Spawn_Spawn[7]);
        Instantiate(Chili, Chili_Spawn_Spawn[9]);
        yield return new WaitForSeconds(3.2f);

        Event_Manager.RandomEvent();

        yield return new WaitForSeconds(1.0f);
        ShimYoungPetans.SetActive(false);
    }
}
