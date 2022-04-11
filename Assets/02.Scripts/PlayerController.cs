using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject Player = null;
    
    public float PlayerMoveSpeed = 2.0f;       //플레이어의 최소 이동속도
    public float PlayerJumpPower = 5.0f;       //플레이어의 점프파워

     public float gravityPower = 0.0f;

    public int jumpCount = 2;     //점프횟수

    public int PlayerHp = 5; // 플레이어의 생명

    private float horizontalMove;

    private Transform PlayerTransform = null;
    private Rigidbody2D PlayerRigidbody2D = null;

    void Start()
    {
        PlayerTransform = GetComponent<Transform>();
        PlayerRigidbody2D = GetComponent<Rigidbody2D>();

        jumpCount = 0;
    }

    private void Update()
    {
       PlayerTransform.position += new Vector3(horizontalMove * Time.deltaTime, 0, 0);
        GameOver();


        if (Input.GetKey(KeyCode.RightArrow))
        {
            ButtonRightDown();
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            ButtonUp();
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ButtonLeftDown();
        }
        else if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            ButtonUp();
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpButton();
        }

    }

    private void FixedUpdate()
    {
        PlayerRigidbody2D.AddForce(Vector3.down * gravityPower);
    }

    // 왼쪽 버튼이 눌렸을때
    public void ButtonLeftDown()
    {
       horizontalMove = -PlayerMoveSpeed;
    }

    //오른쪽 버튼이 눌렸을때
    public void ButtonRightDown()
    {
        horizontalMove = PlayerMoveSpeed;
    }

    public void ButtonUp()
    {
         horizontalMove = 0;
    }

    public void JumpButton()
    {
        if (jumpCount > 0)
        {
            PlayerRigidbody2D.velocity = Vector2.zero;  // 점프를 할때 현재 Player가 가지고 있는 물리적 에너지를 초기화 (기존의 힘X, 마찰 X)
            PlayerRigidbody2D.AddForce(new Vector3(0, 1, 0) * PlayerJumpPower, ForceMode2D.Impulse); //위방향으로 올라가게함
            jumpCount--;    //점프할때 마다 점프횟수 감소
        }
    }

    public void GameOver()
    {
        if(PlayerHp <= 0)
        {
            Event_Manager.isPlay = false;
            Destroy(Player, 0.1f);
            SceneManager.LoadScene(2);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //print("물리 충돌 발생");
            jumpCount = 2; //Ground에 닿으면 점프횟수가 2로 초기화됨
        }
        if(collision.gameObject.tag == "HostileObject")
        {
            PlayerHp--;
            Debug.Log("엄 Hp감소");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "HostileObject")
        {
            PlayerHp--;
            Debug.Log("HP감소");
        }
    }
}