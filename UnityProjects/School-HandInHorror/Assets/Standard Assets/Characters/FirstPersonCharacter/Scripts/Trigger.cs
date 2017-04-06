using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
    public GameObject scare;
    private bool Played;
    private bool Triged;
	// Use this for initialization
	void Start () {
        scare.gameObject.GetComponent<Renderer>().enabled = false;
        Played = false;
        this.gameObject.GetComponent<Renderer>().enabled = false;
	}

    void OnCollisionEnter(Collision col)
    {
            scare.gameObject.GetComponent<Renderer>().enabled = true;
        Triged = true;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
