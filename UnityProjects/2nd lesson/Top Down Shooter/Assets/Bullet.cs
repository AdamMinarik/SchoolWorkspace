using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, 0f, 100 * Time.deltaTime);
    }
}
