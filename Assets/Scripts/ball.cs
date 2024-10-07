using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] private float fuerza;
    int puntuacion_Player1;
    int puntuacion_Player2;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent: para referisrse a los componentes del gameobject (en este caso el rigibody de la bola)
        //impulso inicial a la bola
        GetComponent<Rigidbody2D>().AddForce(new Vector2(1,1).normalized * fuerza, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    //se ejecuta el void EL FRAME EN EL QUE la bola EMPIEZA A
    //atraviesa una zona de trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Porteria 1") 
        {
            Debug.Log("GOL JUGADOR 1");
            puntuacion_Player1 ++;
        }
        else if (collision.tag == "Porteria 2")
        {
            Debug.Log("GOL JUGADOR 2");
            puntuacion_Player2 ++;
        }
    }
}
