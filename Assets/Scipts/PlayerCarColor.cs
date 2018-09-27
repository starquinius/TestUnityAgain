using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarColor : MonoBehaviour {

    //Initialization
    public Material materialR;
    public Material materialB;
    public Material materialY;
    public Material materialM;
    public Material materialWheel;
    public static int bodyColorNr=1;

    public GameObject skyCarBody;
    public GameObject skyCarWheel01;
    public GameObject skyCarWheel02;
    public GameObject skyCarWheel03;
    public GameObject skyCarWheel04;

    void Start()
    {
        skyCarBody.GetComponent<MeshRenderer>().material = materialB;
        skyCarWheel01.GetComponent<MeshRenderer>().material = materialWheel;
        skyCarWheel02.GetComponent<MeshRenderer>().material = materialWheel;
        skyCarWheel03.GetComponent<MeshRenderer>().material = materialWheel;
        skyCarWheel04.GetComponent<MeshRenderer>().material = materialWheel;
    }

    private void Update()
    {
        //Check if the key R is pressed on the keyboard during gaming
        bool changeColor = Input.GetKeyDown(KeyCode.C);

        if (changeColor)
        {
            bodyColorNr++;

            switch (bodyColorNr)
            {
                case 5:
                    skyCarBody.GetComponent<MeshRenderer>().material = materialB;
                    bodyColorNr = 1;
                    break;
                case 2:
                    skyCarBody.GetComponent<MeshRenderer>().material = materialR;
                    break;
                case 3:
                    skyCarBody.GetComponent<MeshRenderer>().material = materialY;
                    break;
                case 4:
                    skyCarBody.GetComponent<MeshRenderer>().material = materialM;
                    break;
            }



        }
    }
}
