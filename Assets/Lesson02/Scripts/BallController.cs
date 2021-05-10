using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float angularVal=1.0f;
    [SerializeField] float maxVelocity = 10.0f;
    [SerializeField] BallSpawner ballSpawner;
    void Start()
    {
        
    }

  
    void Update()
    {
        if (rb.angularVelocity.magnitude>1.0f&&rb.velocity.magnitude<maxVelocity)
        {
            rb.velocity *=angularVal;
        }

        if (this.gameObject.transform.position.y < -2.0)
        {
            Destroy(this.gameObject);
            ballSpawner.Spawn();
        }
    }
}