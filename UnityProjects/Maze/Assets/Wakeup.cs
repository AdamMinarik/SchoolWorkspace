using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wakeup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().WakeUp();
    }
}
