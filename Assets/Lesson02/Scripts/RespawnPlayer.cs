using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    Vector3 respawnPos=new Vector3(0.0f, 0.0f, 0.0f);
    void Start()
    {
        respawnPos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.gameObject.transform.position.y);
        if (this.gameObject.transform.position.y < -1.0f)
        {
            Debug.Log("Hello");

            characterController.enabled = false;
            this.gameObject.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            characterController.enabled = true;
        }
    }
}
