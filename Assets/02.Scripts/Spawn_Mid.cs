using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Mid : MonoBehaviour
{

    public GameObject SandsImage;     //샌즈의 이미지를 저장하는 변수
    public GameObject GusterBlaster;   //샌즈의 레이저를 발사할 구스터블래스터를 저장하는 변수
    public GameObject UndertakerBoysImage;   //관짝소년단의 전면샷을 저장하는 변수
    public GameObject RunUndertakerBoysImage;    //관을 들고 돌진하는 관짝소년단의 이미지를 저장하는 변수
    public GameObject RupeeImage01;  // 군침이 싹도는 루피를 저장하는 변수
    public GameObject RupeeImage02;  //  군침이 터져나오는 루피를 저장하는 변수

    public Transform MidTransform;

    public float currentTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        MidTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sands()
    {
        Instantiate(SandsImage, MidTransform.position,MidTransform.rotation,MidTransform);
    }

    public void UndertakerBoys()
    {
        Instantiate(UndertakerBoysImage, MidTransform.position, MidTransform.rotation, MidTransform);
    }

    public void Rupee()
    {
        Instantiate(RupeeImage01, new Vector3(0, 1.4f, 0), MidTransform.rotation, MidTransform);
    }


}
