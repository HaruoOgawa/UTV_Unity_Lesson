using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Spawn()
    {
        GameObject obj = Instantiate(ball);
        obj.transform.position = this.gameObject.transform.position;
    }
}
