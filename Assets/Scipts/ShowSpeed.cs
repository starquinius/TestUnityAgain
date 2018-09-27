using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class ShowSpeed : MonoBehaviour {

    public string txtSpeed;
    public GameObject playerCar;
    public GameObject showSpeed;

    // Update is called once per frame
    void Update () {
        txtSpeed = playerCar.GetComponent<CarController>().CurrentSpeed.ToString("F0");
        showSpeed.GetComponent<Text>().text = txtSpeed;
    }
}
