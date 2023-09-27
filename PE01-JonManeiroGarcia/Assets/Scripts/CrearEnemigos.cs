using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigos : MonoBehaviour
{
    public GameObject enemigo;

    private List<Vector2> spawners = new List<Vector2>();
    // Start is called before the first frame update
    void Start()
    {
        //4 posiciones de Spawn:
        /*
            Arr Izq = -8.50 , 3.50
            Arr Der = 8.50 , 3.50
            Abj Izq = -8.50 , -3.50
            Abj Der = 8.50 , -3.50
        */
        spawners.Add(new Vector2(-8.50f , 3.50f));
        spawners.Add(new Vector2( 8.50f , 3.50f));
        spawners.Add(new Vector2(-8.50f , -3.50f));
        spawners.Add(new Vector2( 8.50f , -3.50f));

        InvokeRepeating("spawnNewEnemy",10.0f,10.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo para spawnear un enemigo en uno de los puntos de Spawn
    void spawnNewEnemy(){

        Instantiate(enemigo, spawners[Random.Range(0,3)], Quaternion.identity);

    }
}
