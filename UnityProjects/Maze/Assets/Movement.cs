using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public int speed = 10;
    public GameObject sphere;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      

        if (Input.GetKey("s"))
        {
            transform.Rotate(0f, 0f, speed * Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            transform.Rotate(0f, 0f, -speed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(speed * Time.deltaTime, 0f, 0);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(-speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey("r"))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            sphere.transform.position = new Vector3(sphere.transform.position.x, this.transform.position.y + 5, sphere.transform.position.z);
        }
    }
}
