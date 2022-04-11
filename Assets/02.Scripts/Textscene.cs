using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textscene : MonoBehaviour
{
    public Text endText;
    public Text topText;
    public Text RankText;
    void Start()
    {
    }

    void Update()
    {
        endText.text = "" + Event_Manager.maxTime * 5;
        topText.text = "" + (int)(Event_Manager.topTime * 5);
        Rank();

    }
    private void Rank()
    {
        if (Event_Manager.maxTime*5 >= 1200)
        {
            RankText.text = "S";
        }
        else if (Event_Manager.maxTime*5 >= 1000)
        {
            RankText.text = "A";
        }
        else if (Event_Manager.maxTime*5 >= 800)
        {
            RankText.text = "B";
        }
        else if (Event_Manager.maxTime*5 >= 600)
        {
            RankText.text = "C";
        }
        else if (Event_Manager.maxTime*5 >= 400)
        {
            RankText.text = "D";
        }
        else if (Event_Manager.maxTime*5>= 200)
        {
            RankText.text = "E";
        }
        else
        {
            RankText.text = "F";
        }
    }
}
