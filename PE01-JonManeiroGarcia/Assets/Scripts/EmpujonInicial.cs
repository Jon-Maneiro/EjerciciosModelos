 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpujonInicial : MonoBehaviour
{

    private Rigidbody2D cuerpoEnemigo;

    // Start is called before the first frame update
    void Start()
    {

    cuerpoEnemigo = GetComponent<Rigidbody2D>();
    //Se aplica una fuerza aleatoria  al enemigo cuando spawnea
    cuerpoEnemigo.AddForce(transform.up * Random.Range(-300.0f, 300.0f));
    cuerpoEnemigo.AddForce(transform.right * Random.Range(-300.0f, 300.0f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
