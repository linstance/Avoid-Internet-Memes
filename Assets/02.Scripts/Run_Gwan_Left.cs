using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_Gwan_Left : MonoBehaviour
{
    public float GwanRunSpeed = 1.0f;   // 관짝소년단이 달려가는 속도

    public Transform RunGwanTransform = null; // 달려나갈 관짝소년단의  트랜스폼


    // Start is called before the first frame update
    void Start()
    {
        RunGwanTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        RunGwanTransform.Translate(Vector2.right * GwanRunSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall_Right"))
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
