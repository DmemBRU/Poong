using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //time deltatime sirve para que se mueva esa unidad por segundo
       
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3 (0,1, 0) * 3 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -1, 0) * 3 * Time.deltaTime);
        }
    }
}
