using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class pwrSpeed : MonoBehaviour
{

    public GameObject playerCar;
    public GameObject playerCarBody;
    public Material newMat;
    public static Material oldMat; //ARGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG

    IEnumerator OnTriggerEnter(Collider colObject)
    {
        //In CarController.cs changed => public float MaxSpeed{ get { return m_Topspeed; } set { m_Topspeed = value; } }
        playerCar.GetComponent<CarController>().MaxSpeed += 10; //MaxSpeed verhogen met 50

        oldMat = colObject.GetComponent<MeshRenderer>().material; //Sla oude MAT op ********************************************* WIP ????

        playerCarBody.GetComponent<MeshRenderer>().material = newMat; //Tijdelijke nieuwe MAT om power aan te geven

        yield return new WaitForSeconds(5);
        playerCar.GetComponent<CarController>().MaxSpeed -= 10; //MaxSpeed terugzetten op (lagere) normale waarde

        playerCarBody.GetComponent<MeshRenderer>().material = oldMat; //Oude MAT terugzetten
    }
}