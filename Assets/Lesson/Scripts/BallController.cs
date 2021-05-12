using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    public float angularVal=1.0f;
    public float maxVelocity = 10.0f;
    public BallSpawner ballSpawner;
    void Start()
    {
        
    }

  
    void Update()
    {
        if (rb.angularVelocity.magnitude>1.0f&&rb.velocity.magnitude<maxVelocity)
        {
            rb.velocity *=angularVal;
        }

        if (this.gameObject.transform.position.y < -10.0)
        {
            Destroy(this.gameObject);
            ballSpawner.Spawn();
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger) || OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("Input Oculus Touch!!");
            Destroy(this.gameObject);
            ballSpawner.Spawn();
        }
    }
}
