using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Jugador_3 : MonoBehaviour

{
    public float velocidad;
    private int cont;
    private int cont2;
    public Text txtPuntos;
    public Text txtVidas;
    private Rigidbody rb;
    private AudioSource sonido;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        sonido=GetComponent<AudioSource>();
        cont=0;
        cont2=3;
        ctext();
        ctext2(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
    

        Vector3 movimiento = new Vector3(movHorizontal,0.0f,0.0f);
        
        rb.AddForce(movimiento*velocidad);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            other.gameObject.SetActive(false);
            cont+=2;
            ctext();
            sonido.Play();
        }
         
    }

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("obstaculo"))
        {
            cont2-=1;
            ctext2();
        }

    }

    void ctext()
    {
        txtPuntos.text = "Puntos: "+cont.ToString();
    }
    void ctext2()
    {
        txtVidas.text = "Vidas: "+cont2.ToString();
    }
}