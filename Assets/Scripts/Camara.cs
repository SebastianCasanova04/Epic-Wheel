using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 diferencia;
    // Start is called before the first frame update
    void Start()
    {
        diferencia = transform.position- jugador.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetAxis("Mouse ScrollWheel") <0)
     {
         if (Camera.main.fieldOfView<=100) {
           Camera.main.fieldOfView +=2; }
        }
        if (Input.GetAxis("Mouse ScrollWheel") >0)
     {
         if (Camera.main.fieldOfView>=0.01) {
           Camera.main.fieldOfView -=2; }
        }
        Vector3 newpos= jugador.transform.position+diferencia;
        transform.position=newpos;
        
    }
}