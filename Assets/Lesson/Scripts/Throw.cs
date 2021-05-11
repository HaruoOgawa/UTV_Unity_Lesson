using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject nowBall = null;
    public GameObject ball;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //if (nowBall != null)
            //{
                Destroy(nowBall);
           // }
            nowBall = Instantiate(ball);
            nowBall.transform.position = this.gameObject.transform.position;
            nowBall.transform.rotation = this.gameObject.transform.rotation;
            Rigidbody rb = nowBall.GetComponent<Rigidbody>();
            rb.AddForce(this.gameObject.transform.forward*100.0f, ForceMode.Impulse);
        }
    }
}
