using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event_Manager : MonoBehaviour
{
   
    public static bool isPlay;
    private bool timeCont;
    private float startTime;
    private int currentTime;
    public Text score;
    public GameObject Ready_01;  //Ready_01을 저장하는 변수
    public GameObject Ready_02;  //Ready_02을 저장하는 변수
    public GameObject[] Events = new GameObject[6];
    public static int maxTime = 0;
    public static int topTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartEvent_Manager());
    }

    // Update is called once per frame
    void Update()
    {
        if (timeCont)
        {
            currentTime = (int)(Time.time - startTime);
            score.text = "" + currentTime * 5;   
        }
        if (!isPlay)
        {
            timeCont = false;
            maxTime = currentTime;
            score.text = "" + maxTime;
            if (maxTime > topTime)
            {
                topTime = maxTime;
            }
        }

    }

    public void RandomEvent()
    {
        int RandomIndex;
        RandomIndex = Random.Range(0, 6);

        print(RandomIndex);

        if(Events[RandomIndex] == Events[0])
        {
            Events[0].SetActive(true);
        } 
        else if(Events[RandomIndex] == Events[1])
        {
            Events[1].SetActive(true);
        }
        else if (Events[RandomIndex] == Events[2])
        {
            Events[2].SetActive(true);
        }
        else if(Events[RandomIndex] == Events[3])
        {
            Events[3].SetActive(true);
        }
        else if (Events[RandomIndex] == Events[4])
        {
            Events[4].SetActive(true);
        }
        else if (Events[RandomIndex] == Events[5])
        {
            Events[5].SetActive(true);
        }
      
    }

    IEnumerator StartEvent_Manager()
    {
        yield return new WaitForSeconds(0.3f);
        Ready_01.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Ready_01.SetActive(false);
        Ready_02.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Ready_02.SetActive(false);
        Ready_01.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Ready_01.SetActive(false);
        Ready_02.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Ready_02.SetActive(false);
        Ready_01.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Ready_01.SetActive(false);
        Ready_02.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Ready_01.SetActive(false);
        Ready_02.SetActive(false);
        isPlay = true;
        startTime = Time.time;
        timeCont = true;
        Invoke("RandomEvent", 1);
    }
}
