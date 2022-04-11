using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Rigidbody2D BulletRigidbody2D = null;
    public float BulletSpeed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        BulletRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BulletRigidbody2D.AddForce(Vector2.right * BulletSpeed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall_Right"))
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
