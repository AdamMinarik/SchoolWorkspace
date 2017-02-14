using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnObject : MonoBehaviour {

    public GameObject obj;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            transform.Translate(0f, 0f, 1f);
            
            obj.transform.Translate(0f, 0f, 1f);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0f, 0f, -1f);
            
            obj.transform.Translate(0f, 0f, -1f);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(-1f, 0f, 0f);
            
            obj.transform.Translate(0f, 0f, -1f);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(1f, 0f, 0f);

            obj.transform.Translate(0f, 0f, -1f);
        }


        if (Input.GetKey("e"))
        {
            transform.Rotate(Vector3.up , 30 * Time.deltaTime);
        }


        Instantiate(bullet, transform.position, transform.)
    }
}
