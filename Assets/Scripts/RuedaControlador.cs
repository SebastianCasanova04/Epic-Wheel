using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RuedaControlador : MonoBehaviour
{
    public float velocidad; 

    public Text textoPuntos;

    private Rigidbody rb;

    private AudioSource sonido;

    private int conteoMoneda;

    private int conteoCubo;

    private float jumpspeed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sonido = GetComponent<AudioSource>();
    

        conteoMoneda = 0;
        cambiarTextoMoneda();
    


        rb = GetComponent<Rigidbody>();
        conteoCubo = 0;
        cambiarTextoCubo();
        
    }

    // Update is called once per frame

    void Update () 
    {
        if(Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        
        Vector3 movimiento = new Vector3(movHorizontal,0.0f,movVertical);

        rb.AddForce(movimiento*velocidad);
    }

    void OnTriggerEnter(Collider otro)
    {
        if(otro.gameObject.CompareTag("moneda"))
       
        {
            otro.gameObject.SetActive(false);
            conteoMoneda += 1;
            cambiarTextoMoneda();
            sonido.Play();
        }
    }

    void cambiarTextoMoneda()
    {
       textoPuntos.text = "Puntos: " + conteoMoneda.ToString();
    }
    void cambiarTextoCubo()
    {
       textoPuntos.text = "Puntos: " + conteoCubo.ToString();
    }
}






    
    
