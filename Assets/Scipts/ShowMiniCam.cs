using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMiniCam : MonoBehaviour {

    // This script turns the mini map cam ON / OFF by a keypress 

    // Initialization
    public GameObject miniMapCamBorder;
    public GameObject miniMapCam;

    // Update is called once per frame
    private void Update()
    {
        //Check if the key R is pressed on the keyboard during gaming
        bool turnMirror = Input.GetKeyDown(KeyCode.M);

        //If R is pressed, check state of RearMirror and turn it accordingly ON or OFF
        if ((turnMirror) && !(miniMapCam.activeSelf))
            TurnMiniMapOn();
        else if ((turnMirror) && (miniMapCam.activeSelf))
            TurnMiniMapOff();
    }

    /// <summary>
    /// Turn Rearview Mirror On
    /// </summary>
    void TurnMiniMapOn()
    {
        miniMapCam.SetActive(true);
        miniMapCamBorder.SetActive(true);
    }

    /// <summary>
    /// Turn Rearview Mirror Off
    /// </summary>
    void TurnMiniMapOff()
    {
        miniMapCam.SetActive(false);
        miniMapCamBorder.SetActive(false);
    }
}
