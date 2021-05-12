using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public CharacterController characterController;
    public Vector3 respawnPos=new Vector3(0.0f, 0.0f, 0.0f);
    void Start()
    {
      
    }

   
    void Update()
    {
        
        if (this.gameObject.transform.position.y < -10.0f)
        {
            characterController.enabled = false;
            this.gameObject.transform.position = respawnPos;
            characterController.enabled = true;
        }
    }
}
