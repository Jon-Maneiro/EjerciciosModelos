using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    private GameObject jugador;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*Se recoge la posicion del raton, 
        se tranforma a pòsicion relativa de la camara
        se mueve al jugador a esa posicion*/
        Vector3 mousePos = Input.mousePosition;
        
        Vector3 worldPos = cam.ScreenToWorldPoint(mousePos);

        this.transform.position = new Vector2(worldPos.x , worldPos.y);

    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        //Se cierra el programa cuando se detecta una colision
        Debug.Log("Ha habido una colisions");
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();

        
    }

}
