using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador_3 : MonoBehaviour

{
    public float velocidad;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
    

        Vector3 movimiento = new Vector3(movHorizontal,0.0f,0.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            movimiento = new Vector3(movHorizontal,20,0.0f);
        }
        
        rb.AddForce(movimiento*velocidad);
    }
}