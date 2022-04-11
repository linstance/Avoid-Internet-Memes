using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandsPetan : MonoBehaviour
{
    public Event_Manager Event_Manager;

    GameObject[] gaster = new GameObject[4];
    GameObject[] san = new GameObject[4];
    GameObject[] clone = new GameObject[4];

    public Transform MyTransform;
    public GameObject[] Gaster;
    public GameObject[] Reiger;
    public GameObject[] San;
    public GameObject Sands;
    public GameObject floorRight;
    public GameObject floorLeft;
    public GameObject[] boon;
    public Transform[] boonspawn;
    public Transform[] target;
    public AudioSource audiosource;
    public AudioClip MainBGM;
    public GameObject SandsEvent;
    float speed = 5;
    

    bool isSands = false;

    void Start()
    {
        MyTransform = GetComponent<Transform>();
        StartCoroutine(ReigerPaten());
        StartCoroutine(boontrue());

        audiosource.clip = MainBGM;
    }

    void Update()
    {
      StartCoroutine(boonmove());
    }
    IEnumerator ReigerPaten()
    {
        audiosource.volume = 0f;

        for (int i = 0; i < 2; i++)
        {
           san[i] = Instantiate(San[i + 2], transform.GetChild(i + 2).position, transform.GetChild(i + 2).rotation);
           Destroy(san[i], 2f);
        }
        yield return new WaitForSeconds(1.5f);

        san[0].SetActive(false);
        san[1].SetActive(false);

        for (int i = 0; i < 2; i++)
        {
            clone[i] = Instantiate(Reiger[i + 2], transform.GetChild(i + 2).position, transform.GetChild(i + 2).rotation);
            Destroy(clone[i], 2f);
        }
        yield return new WaitForSeconds(1f);

        clone[0].SetActive(false);
        clone[1].SetActive(false);

        for (int i = 0; i < 2; i++)
        {
            san[i + 2] = Instantiate(San[i], transform.GetChild(i).position, transform.GetChild(i).rotation);
            Destroy(san[i+2], 2f);
        }
        yield return new WaitForSeconds(1.5f);

        san[2].SetActive(false);
        san[3].SetActive(false);

        for (int i = 0; i < 2; i++)
        {
            clone[i + 2] = Instantiate(Reiger[i], transform.GetChild(i).position, transform.GetChild(i).rotation);
            Destroy(clone[i+2], 2f);
        }
        yield return new WaitForSeconds(1f);

        clone[2].SetActive(false);
        clone[3].SetActive(false);

        for (int i = 0; i < 2; i++)
        {
            san[i] = Instantiate(San[i + 2], transform.GetChild(i + 2).position, transform.GetChild(i + 2).rotation);
            Destroy(san[i], 2f);
        }
        yield return new WaitForSeconds(1.5f);

        san[0].SetActive(false);
        san[1].SetActive(false);

        for (int i = 0; i < 2; i++)
        {
            clone[i] = Instantiate(Reiger[i + 2], transform.GetChild(i + 2).position, transform.GetChild(i + 2).rotation);
            Destroy(clone[i], 2f);
        }
        yield return new WaitForSeconds(1f);

        for (int i = 0; i < 2; i++)
        {
            san[i + 2] = Instantiate(San[i], transform.GetChild(i).position, transform.GetChild(i).rotation);
            Destroy(san[i+2], 4f);
        }
        yield return new WaitForSeconds(1.5f);

        san[2].SetActive(false);
        san[3].SetActive(false);

        for (int i = 0; i < 2; i++)
        {
            clone[i + 2] = Instantiate(Reiger[i], transform.GetChild(i).position, transform.GetChild(i).rotation);
            Destroy(clone[i+2], 3f);
        }
        yield return new WaitForSeconds(3f);

        Gaster[0].SetActive(false);
        Gaster[1].SetActive(false);
        Gaster[2].SetActive(false);
        Gaster[3].SetActive(false);

        floorRight.SetActive(false);
        floorLeft.SetActive(false);

        yield return new WaitForSeconds(13f);

        audiosource.volume = 0.4f;

        yield return new WaitForSeconds(0.2f);

        SandsEvent.SetActive(false);
    }

    IEnumerator boontrue()
    {

        yield return new WaitForSeconds(14f);

        boon[0].SetActive(true);
        boon[1].SetActive(true);
        boon[2].SetActive(true);

        yield return new WaitForSeconds(6f);

        boon[3].SetActive(true);
        boon[4].SetActive(true);
        boon[5].SetActive(true);

        yield return new WaitForSeconds(3f);

        boon[0].SetActive(false);
        boon[1].SetActive(false);
        boon[2].SetActive(false);

        yield return new WaitForSeconds(2f);

        boon[3].SetActive(false);
        boon[4].SetActive(false);
        boon[5].SetActive(false);
    }

    IEnumerator boonmove()
    {
        yield return new WaitForSeconds(1f);

        if (boon[0].activeSelf == true)
        {
            boon[0].transform.position = Vector2.MoveTowards(new Vector2(boon[0].transform.position.x, boon[0].transform.position.y), new Vector2(target[0].position.x, target[0].position.y), speed * Time.deltaTime);
        }
        if(boon[1].activeSelf == true)
        {
          boon[1].transform.position = Vector2.MoveTowards(new Vector2(boon[1].transform.position.x, boon[1].transform.position.y), new Vector2(target[1].position.x, target[1].position.y), speed * Time.deltaTime);
        }
        if(boon[2].activeSelf == true)
        {
          boon[2].transform.position = Vector2.MoveTowards(new Vector2(boon[2].transform.position.x, boon[2].transform.position.y), new Vector2(target[2].position.x, target[2].position.y), speed * Time.deltaTime);
        }

        yield return new WaitForSeconds(0.5f);

        if (boon[3].activeSelf == true)
        {
            boon[3].transform.position = Vector2.MoveTowards(new Vector2(boon[3].transform.position.x, boon[3].transform.position.y), new Vector2(target[3].position.x, target[3].position.y), speed * Time.deltaTime);
        }
        if (boon[4].activeSelf == true)
        {
            boon[4].transform.position = Vector2.MoveTowards(new Vector2(boon[4].transform.position.x, boon[4].transform.position.y), new Vector2(target[4].position.x, target[4].position.y), speed * Time.deltaTime);
        }
        if (boon[5].activeSelf == true)
        {
            boon[5].transform.position = Vector2.MoveTowards(new Vector2(boon[5].transform.position.x, boon[5].transform.position.y), new Vector2(target[5].position.x, target[5].position.y), speed * Time.deltaTime);
        }
    
    }
}
