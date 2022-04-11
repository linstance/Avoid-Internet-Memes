using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenEgg_01 : MonoBehaviour
{
    public GameObject bullet;   // 깨진 달걀이 발사할 총알
    public Transform MyTransform;
    //public Vector2 EggVector2; //달걀이 가진 위치값
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

     }

    public void Shoot01()
    {
        for (int i = 0; i < 360; i += 24)
        {
            //총알 생성
            GameObject temp = Instantiate(bullet, MyTransform);

            //2초마다 삭제
            Destroy(temp, 2f);

            //Z에 값이 변해야 회전이 이루어지므로, Z에 i를 대입한다.
            temp.transform.rotation = Quaternion.Euler(0, 0, i);
        }
    }

}


