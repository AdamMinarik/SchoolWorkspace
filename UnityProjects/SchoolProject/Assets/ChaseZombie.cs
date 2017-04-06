using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseZombie : MonoBehaviour
{

    public int health = 100;
    public Transform player;
    public float walkingDistance = 10.0f;
    public float smoothTime = 10.0f;
    private Vector3 smoothVelocity = Vector3.zero;
    private bool showText = false;

    void Update()
    {
        transform.LookAt(player);
        float distance = Vector3.Distance(transform.position, player.position);


        if (distance < walkingDistance)
        {
   
            transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            health-=10;

            if(health <=0)
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "player")
        {
            showText = true;
            Time.timeScale = 0;
            
        }
    }

    

}