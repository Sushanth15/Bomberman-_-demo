using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour {
    public AudioSource aud1;
    void Start()
    {
        aud1 = GameObject.Find("die").GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "worm")
        {   
            aud1.Play();
            Destroy(gameObject);
            
        }
    }
    // Use this for initialization
  
	// Update is called once per frame
	void Update () {
		
	}
}
