using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource aud;
    void Start()
    {
        aud = GameObject.Find("explode").GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col) {
    
		if (!col.gameObject.isStatic ) {
            aud.Play();
            Destroy (col.gameObject);

            
        }
	}
}
