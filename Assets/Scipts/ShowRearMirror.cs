using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRearMirror : MonoBehaviour
{

    // This script turns the rear view mirror ON / OFF by a keypress 

    // Initialization
    public GameObject mirrorBorder;
    public GameObject rearMirror;

    // Update is called once per frame
    private void Update()
    {
        //Check if the key R is pressed on the keyboard during gaming
        bool turnMirror = Input.GetKeyDown(KeyCode.R);

        //If R is pressed, check state of RearMirror and turn it accordingly ON or OFF
        if ((turnMirror) && !(rearMirror.activeSelf))
            TurnRearMirrorOn();
        else if ((turnMirror) && (rearMirror.activeSelf))
            TurnRearMirrorOff();
    }

    /// <summary>
    /// Turn Rearview Mirror On
    /// </summary>
    void TurnRearMirrorOn()
    {
        rearMirror.SetActive(true);
        mirrorBorder.SetActive(true);
    }

    /// <summary>
    /// Turn Rearview Mirror Off
    /// </summary>
    void TurnRearMirrorOff()
    {
        rearMirror.SetActive(false);
        mirrorBorder.SetActive(false);
    }
}
