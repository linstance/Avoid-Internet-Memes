using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hp_Bar : MonoBehaviour
{
   public PlayerController playerController;

    public Image[] Hp = new Image[6];

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
        
    {
        HpBar();
    }

    void HpBar()
    {
        if (playerController.PlayerHp == 5)
        {
            Hp[1].gameObject.SetActive(true);
            Hp[2].gameObject.SetActive(true);
            Hp[3].gameObject.SetActive(true);
            Hp[4].gameObject.SetActive(true);
            Hp[5].gameObject.SetActive(true);
        }
        else if (playerController.PlayerHp == 4)
        {
            Hp[1].gameObject.SetActive(true);
            Hp[2].gameObject.SetActive(true);
            Hp[3].gameObject.SetActive(true);
            Hp[4].gameObject.SetActive(true);
            Hp[5].gameObject.SetActive(false);
        }
        else if (playerController.PlayerHp == 3)
        {
            Hp[1].gameObject.SetActive(true);
            Hp[2].gameObject.SetActive(true);
            Hp[3].gameObject.SetActive(true);
            Hp[4].gameObject.SetActive(false);
            Hp[5].gameObject.SetActive(false);
        }
        else if (playerController.PlayerHp == 2)
        {
            Hp[1].gameObject.SetActive(true);
            Hp[2].gameObject.SetActive(true);
            Hp[3].gameObject.SetActive(false);
            Hp[4].gameObject.SetActive(false);
            Hp[5].gameObject.SetActive(false);
        }
        else if (playerController.PlayerHp == 1)
        {
            Hp[1].gameObject.SetActive(true);
            Hp[2].gameObject.SetActive(false);
            Hp[3].gameObject.SetActive(false);
            Hp[4].gameObject.SetActive(false);
            Hp[5].gameObject.SetActive(false);
        }
        else if (playerController.PlayerHp == 0)
        {
            Hp[1].gameObject.SetActive(false);
            Hp[2].gameObject.SetActive(false);
            Hp[3].gameObject.SetActive(false);
            Hp[4].gameObject.SetActive(false);
            Hp[5].gameObject.SetActive(false);
        }
    }
}