using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionTrigger : MonoBehaviour
{

    public BoxCollider2D playerCollider;
    public BoxCollider2D platformCollider;
    public BoxCollider2D platformTrigger;

    // Use this for initialization
    void Start()
    {
        Physics2D.IgnoreCollision(platformCollider, platformTrigger, true);
        Physics2D.IgnoreCollision(playerCollider, platformTrigger, true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Physics2D.IgnoreCollision(playerCollider, platformCollider, true);
        }
    }



}