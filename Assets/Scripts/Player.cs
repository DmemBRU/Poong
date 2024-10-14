using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
        //para que no excedan su posicion
        float yClamped = Mathf.Clamp(transform.position.y, -3.73f, 3.73f);
        transform.position = new Vector3(transform.position.x, yClamped, transform.position.z);
    }
}
