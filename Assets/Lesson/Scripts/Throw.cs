using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject nowBall = null;
    public GameObject ball;
   
    void Start()
    {
        
    }

  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(nowBall);
            nowBall = Instantiate(ball);
            nowBall.transform.position = this.gameObject.transform.position;
            nowBall.transform.rotation = this.gameObject.transform.rotation;
            Rigidbody rb = nowBall.GetComponent<Rigidbody>();
            rb.AddForce(this.gameObject.transform.forward*100.0f, ForceMode.Impulse);
        }
    }
}
