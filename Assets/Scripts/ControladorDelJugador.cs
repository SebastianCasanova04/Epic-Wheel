using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDelJugador : MonoBehaviour
{
    public float velocidad;
    private Rigidbody rb;
    public float salto;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0,salto);
        }
        
        Vector3 movimiento = new Vector3(movHorizontal,0.0f,movVertical);

        rb.AddForce(movimiento*velocidad);

        Vector3 nada = new Vector3(0.0f,0.0f,0.0f);
    }
}
