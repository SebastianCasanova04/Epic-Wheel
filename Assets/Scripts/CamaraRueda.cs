using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraRueda : MonoBehaviour
{
    public GameObject Rueda;
    public Camera minimap;

    private Vector3 diferencia; 
    // Start is called before the first frame update
    void Start()
    {
        diferencia = transform.position - Rueda.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()

    {
        if (Input.GetAxis("Mouse ScrollWheel") > 100f ) // forward 
        {
            minimap.orthographicSize++;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 100f ) // backwards 
        {
            minimap.orthographicSize--;
        }
         
       {
       Vector3 nuevaPos =  Rueda.transform.position + diferencia;
       transform.position = nuevaPos;
       }
    }   
}
