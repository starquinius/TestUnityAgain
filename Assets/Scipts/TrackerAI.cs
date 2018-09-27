using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerAI : MonoBehaviour {

    public GameObject tracker;
    public int trackerNumber=0;
    public GameObject wayPoint01;
    public GameObject wayPoint02;
    public GameObject wayPoint03;
    public GameObject wayPoint04;
    public GameObject wayPoint05;
    public GameObject wayPoint06;
    public GameObject wayPoint07;
    public GameObject wayPoint08;
    public GameObject wayPoint09;
    public GameObject wayPoint10;
    public GameObject wayPoint11;
    public GameObject wayPoint12;
    public GameObject wayPoint13;
    public GameObject wayPoint14;
    public GameObject wayPoint15;
    public GameObject wayPoint16;
    public GameObject wayPoint17;
    public GameObject wayPoint18;
    public GameObject wayPoint19;
    public GameObject wayPoint20;
    public GameObject wayPoint21;


    // Update is called once per frame
    void Update () {
        if (trackerNumber == 0)
            tracker.transform.position = wayPoint01.transform.position;
        if (trackerNumber == 1)
            tracker.transform.position = wayPoint02.transform.position;
        if (trackerNumber == 2)
            tracker.transform.position = wayPoint03.transform.position;
        if (trackerNumber == 3)
            tracker.transform.position = wayPoint04.transform.position;
        if (trackerNumber == 4)
            tracker.transform.position = wayPoint05.transform.position;
        if (trackerNumber == 5)
            tracker.transform.position = wayPoint06.transform.position;
        if (trackerNumber == 6)
            tracker.transform.position = wayPoint07.transform.position;
        if (trackerNumber == 7)
            tracker.transform.position = wayPoint08.transform.position;
        if (trackerNumber == 8)
            tracker.transform.position = wayPoint09.transform.position;
        if (trackerNumber == 9)
            tracker.transform.position = wayPoint10.transform.position;
        if (trackerNumber == 10)
            tracker.transform.position = wayPoint11.transform.position;
        if (trackerNumber == 11)
            tracker.transform.position = wayPoint12.transform.position;
        if (trackerNumber == 12)
            tracker.transform.position = wayPoint13.transform.position;
        if (trackerNumber == 13)
            tracker.transform.position = wayPoint14.transform.position;
        if (trackerNumber == 14)
            tracker.transform.position = wayPoint15.transform.position;
        if (trackerNumber == 15)
            tracker.transform.position = wayPoint16.transform.position;
        if (trackerNumber == 16)
            tracker.transform.position = wayPoint17.transform.position;
        if (trackerNumber == 17)
            tracker.transform.position = wayPoint18.transform.position;
        if (trackerNumber == 18)
            tracker.transform.position = wayPoint19.transform.position;
        if (trackerNumber == 19)
            tracker.transform.position = wayPoint20.transform.position;
        if (trackerNumber == 20)
            tracker.transform.position = wayPoint21.transform.position;

    }

    /// <summary>
    /// Check Tag On Collider if it's AI CAR
    /// </summary>
    /// <param name="collision"></param>
    /// <returns></returns>
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "aiCar")
        {
            this.GetComponent<CapsuleCollider>().enabled = false;
            trackerNumber++;
            if (trackerNumber == 21)
                trackerNumber = 0;
        }
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<CapsuleCollider>().enabled = true;
    }

}
