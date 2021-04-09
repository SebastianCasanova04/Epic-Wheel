using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JugadorControlador : MonoBehaviour
{
    public float velocidad;
    public float salto;
    public Text textoPuntos;
    public Text TextoTerminado;
    public Text TextoPuntuacion;
    private Rigidbody rb;
    private AudioSource sonido;
    public AudioSource sonidoRueda;
    public AudioSource sonidoPeligro;
    private int conteo;
    private int conteoMonedas;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sonido = GetComponent<AudioSource>();
        conteo = 0;
        conteoMonedas = 0;
        cambiarTexto();
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
        
        if (movimiento != nada && sonidoRueda.isPlaying != true)
        {
            sonidoRueda.Play();            
        }
    }
    void OnTriggerEnter(Collider otro)
    {
        if(otro.gameObject.CompareTag("Moneda"))
        {
            otro.gameObject.SetActive(false);
            conteo += 1;
            conteoMonedas += 1;
            cambiarTexto();
            sonido.Play();
        }
        else
        {
            otro.gameObject.SetActive(false);
            conteo -= 1;
            sonidoPeligro.Play();
            cambiarTexto();
        }
        if(conteoMonedas == 8)
        {
            TextoTerminado.text = "Haz terminado!!";
            TextoPuntuacion.text = "Tu puntaje Final es: " + conteo;
        }

    }
    void cambiarTexto()
    {
        textoPuntos.text = "Puntos " + conteo.ToString();
    }
}
