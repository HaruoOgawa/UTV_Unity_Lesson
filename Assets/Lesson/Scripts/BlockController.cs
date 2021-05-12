using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
   
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }
}
