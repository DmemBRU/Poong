using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3( 1, 0, 0)* 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}