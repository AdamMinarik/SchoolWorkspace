using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    // Use this for initialization
    public int speed= 10;
    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f,-(speed * Time.deltaTime));
    }
}
