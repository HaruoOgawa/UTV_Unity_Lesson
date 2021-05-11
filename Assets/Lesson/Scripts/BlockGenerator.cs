using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    [SerializeField] GameObject block;

    [SerializeField] int xSegment = 8;
    [SerializeField] int ySegment = 3;
    [SerializeField] int zSegment = 6;

    [SerializeField] float xWidth = 3.0f;
    [SerializeField] float yWidth = 3.0f;
    [SerializeField] float zWidth = 3.0f;

   
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
