using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject block;

    public int xSegment = 8;
    public int ySegment = 3;
    public int zSegment = 6;

    public float xWidth = 3.0f;
    public float yWidth = 3.0f;
    public float zWidth = 3.0f;

   
    
    void Start()
    {
        Vector3 startPos = this.gameObject.transform.position;

        for (int i = 0; i < xSegment; i++)
        {
            for (int p = 0; p < ySegment; p++)
            {
                for (int q = 0; q < zSegment; q++)
                {
                    GameObject obj = Instantiate(block);
                    obj.transform.position = startPos + new Vector3(i * xWidth, p * yWidth, q * zWidth);
                    obj.transform.parent = this.gameObject.transform;
                }
            }
        }
    }

   
    void Update()
    {
        
    }
}
