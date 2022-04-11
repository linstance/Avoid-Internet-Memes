using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chili : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D ChiliRd2D;

    public float gravityPower = 1f;

    void Start()
    {
        ChiliRd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ChiliRd2D.AddForce(Vector2.down * gravityPower);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("플레이어 관충돌");

        if (collision.gameObject.CompareTag("Ground"))
        {
            print("고추삭제");
            Destroy(gameObject, 0.1f);  //관 삭제
        }
    }
}
