using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rupee2 : MonoBehaviour
{

    public GameObject bullet;   //루피2 공격에 사용할 오브젝트 넣을 곳
    public float speed = 5f; //루피2 공격 오브젝트의 스피드
    public GameObject Rupee2AttackSpawn;    //루피2 공격 스폰위치

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Rupee());
    }
    IEnumerator Rupee()
    {
        yield return new WaitForSeconds(0f);

        //yield return new WaitForSeconds(20f);

        //bullet[0].transform.position = Vector2.MoveTowards(new Vector2(bullet[0].transform.position.x, bullet[0].transform.position.y), new Vector2(target[0].position.x, target[0].position.y), speed * Time.deltaTime);
        //bullet[1].transform.position = Vector2.MoveTowards(new Vector2(bullet[1].transform.position.x, bullet[1].transform.position.y), new Vector2(target[1].position.x, target[1].position.y), speed * Time.deltaTime);
        //bullet[2].transform.position = Vector2.MoveTowards(new Vector2(bullet[2].transform.position.x, bullet[2].transform.position.y), new Vector2(target[2].position.x, target[2].position.y), speed * Time.deltaTime);
        //bullet[3].transform.position = Vector2.MoveTowards(new Vector2(bullet[3].transform.position.x, bullet[3].transform.position.y), new Vector2(target[3].position.x, target[3].position.y), speed * Time.deltaTime);
        //bullet[4].transform.position = Vector2.MoveTowards(new Vector2(bullet[4].transform.position.x, bullet[4].transform.position.y), new Vector2(target[4].position.x, target[4].position.y), speed * Time.deltaTime);

        //yield return new WaitForSeconds(2f);

        //bullet[0].transform.localPosition = new Vector3(22.45466f, 13.02143f, 0f);
        //bullet[1].transform.localPosition = new Vector3(22.45466f, 13.02143f, 0f);
        //bullet[2].transform.localPosition = new Vector3(22.45466f, 13.02143f, 0f);
        //bullet[3].transform.localPosition = new Vector3(22.45466f, 13.02143f, 0f);
        //bullet[4].transform.localPosition = new Vector3(22.45466f, 13.02143f, 0f);


    }
}
