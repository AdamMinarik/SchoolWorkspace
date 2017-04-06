using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Rigidbody bullet;
    public float speed = 10f;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("g"))
        {
            Rigidbody bulletClone = (Rigidbody) Instantiate(bullet, transform.position, transform.rotation);
            bulletClone.velocity = transform.forward * speed;

            Debug.Log("debug");
        }
    }
}
