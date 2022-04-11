using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandsEvent : MonoBehaviour
{
    public GameObject SandsEvents;
    public Event_Manager Event_Manager;

    // Start is called before the first frame update
    void Start()
    {
        Event_Manager = GameObject.Find("GameManager").GetComponent<Event_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SandsEvents == false){
            Event_Manager.RandomEvent();
        }
    }

}