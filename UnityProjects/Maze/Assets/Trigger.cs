using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
    public GameObject ball;
    public GameObject desk;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision Collection)
    {
        if (Collection.gameObject.name == "Ball")
        {
            ball.transform.position = new Vector3(-8, 2, 8);
            desk.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

