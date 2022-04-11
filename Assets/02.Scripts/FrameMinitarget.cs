using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FrameMinitarget : MonoBehaviour
{
    public GameObject Frame; //액자
    public Transform Minitarget1;  //작은 액자타겟1
    public Transform Minitarget2;  //작은 액자타겟2
    public Transform Minitarget3;  //작은 액자타겟3
    public GameObject Mini1; //작은 액자1
    public GameObject Mini2; //작은 액자2
    public GameObject Mini3; //작은 액자3
    float speed = 2;    //스피드 5줌
    public GameObject Explosion;    //폭발 이미지



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      StartCoroutine( Move());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "FrameMini1")
        {
            Mini1.SetActive(false); //비활성화
            GameObject a = Instantiate(Explosion, transform.position, transform.rotation);//클론생성
            Destroy(a, 2f);//클론 2초후 삭제
        }
        if (collision.gameObject.name == "FrameMini2")
        {
            Mini2.SetActive(false);//비활성화
            GameObject a = Instantiate(Explosion, transform.position, transform.rotation); //클론생성
            Destroy(a, 2f);//클론 2초후 삭제
        }
        if (collision.gameObject.name == "FrameMini3")
        {
            Mini3.SetActive(false); //비활성화
            GameObject a = Instantiate(Explosion, transform.position, transform.rotation);  //클론생성
            Destroy(a, 2f); //클론 2초후 삭제
        }
    }
    IEnumerator Move()
    {
        yield return new WaitForSeconds(2f);
        if (Mini1.activeSelf == true )
        {
            //작은 액자가 타겟을 따라감
            Mini1.transform.position = Vector2.MoveTowards(new Vector2(Mini1.transform.position.x, Mini1.transform.position.y), new Vector2(Minitarget1.position.x, Minitarget1.position.y), speed * Time.deltaTime);
        }
        if (Mini2.activeSelf == true)
        {
            //작은 액자가 타겟을 따라감
            Mini2.transform.position = Vector2.MoveTowards(new Vector2(Mini2.transform.position.x, Mini2.transform.position.y), new Vector2(Minitarget2.position.x, Minitarget2.position.y), speed * Time.deltaTime);
        }
        if (Mini2.activeSelf == true)
        {
            //작은 액자가 타겟을 따라감
            Mini3.transform.position = Vector2.MoveTowards(new Vector2(Mini3.transform.position.x, Mini3.transform.position.y), new Vector2(Minitarget3.position.x, Minitarget3.position.y), speed * Time.deltaTime);
        }
        if (Mini1.activeSelf == false && Mini2.activeSelf == false && Mini3.activeSelf == false)
        {
            Mini1.transform.position = new Vector3(1.49f,2.98f,0f); //Mini1 제자리로 보냄
            Mini2.transform.position = new Vector3(-0.46f,0.27f,0f);//Mini2 제자리로 보냄
            Mini3.transform.position = new Vector3(3.15f,0.27f,0f);//Mini3 제자리로 보냄
        }
    }
        
}
