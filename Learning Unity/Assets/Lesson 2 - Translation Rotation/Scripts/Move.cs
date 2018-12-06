using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public int speed = 3;
    public int turnSpeed = 40; 
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.W))
        {
            transform.Translate( Vector3.forward * speed * Time.deltaTime );
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate( Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        }
    }
}
