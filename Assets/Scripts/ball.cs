using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ball : MonoBehaviour
{
    [SerializeField] private float fuerza;
    int puntuacion_Player1;
    int puntuacion_Player2;
    [SerializeField] TMP_Text puntuacion1;
    [SerializeField] TMP_Text puntuacion2;
    [SerializeField]Vector2 posicionOg;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent: para referisrse a los componentes del gameobject (en este caso el rigibody de la bola)
        //impulso inicial a la bola
        GetComponent<Rigidbody2D>().AddForce(new Vector2(1,1).normalized * fuerza, ForceMode2D.Impulse);
        posicionOg = transform.position;    
         
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    //se ejecuta el void EL FRAME EN EL QUE la bola EMPIEZA A
    //atraviesa una zona de trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Porteria 1")) 
        {
            Debug.Log("GOL JUGADOR 1");
            puntuacion_Player1 ++;
            puntuacion1.SetText("P1: " + puntuacion_Player1);
            transform.position = posicionOg;
            ReiniciarBola();
            
        }
        else if (collision.CompareTag ("Porteria 2"))
        {
            Debug.Log("GOL JUGADOR 2");
            puntuacion_Player2 ++;
            puntuacion2.SetText("P2: " + puntuacion_Player2);
            transform.position = posicionOg;
            ReiniciarBola ();
           
        }

    }
    void ReiniciarBola()
    {
        rb.velocity = new Vector3 (0,0,0);
        int numR1 = Random.Range (-1, 2);
        int numR2 = Random.Range (-1, 2);
        while (numR1 == 0 || numR2 == 0) 
        {
            numR1 = Random.Range(-1, 2);

            numR2 = Random.Range(-1, 2);
        }
       
        GetComponent<Rigidbody2D>().AddForce(new Vector2(numR1, numR2).normalized * fuerza, ForceMode2D.Impulse);
        
    }
}
