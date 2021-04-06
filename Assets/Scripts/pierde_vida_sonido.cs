using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pierde_vida_sonido : MonoBehaviour
{
    private AudioSource sonido;
    // Start is called before the first frame update
    void Start()
    {
        sonido=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other) 
    {
        
        sonido.Play();
        

    }
}
