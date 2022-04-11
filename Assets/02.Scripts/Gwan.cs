using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gwan : MonoBehaviour
{
    // Start is called before the first frame update
   
    public Rigidbody2D GwanRd2D;

    public float gravityPower = 1f;

    void Start()
    {
        GwanRd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GwanRd2D.AddForce(Vector2.down * gravityPower);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("플레이어 관충돌");

        if (collision.gameObject.CompareTag("Ground"))
        {
            print("관삭제");
            Destroy(gameObject, 0.1f);  //관 삭제
        }
    }
}
