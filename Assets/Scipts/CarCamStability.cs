using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCamStability : MonoBehaviour {

    // This script lets the camera follow the cube above the car. 
    // The cube can't rotate as the car does in a collision.
    // So the camera won't rotate as the car rotates

    // Initialization
    public GameObject playerCar; //Players Car
    public Vector3 playerCarCoordinate; //Coordinates of Players Car
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Get Rotation Values Coordinate Y of the Car (and thereby the Cube on the Car)
        float playerCarRotateValueY = playerCar.transform.eulerAngles.y;
        
        //New rotation coordinates for the cube, so it wont rotate with the car
        transform.eulerAngles = new Vector3(0, playerCarRotateValueY, 0);
          
	}
}
