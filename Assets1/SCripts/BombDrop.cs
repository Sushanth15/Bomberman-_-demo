using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrop : MonoBehaviour {

	public GameObject bombPrefab;
    public AudioSource aud2;

     void Start()
    {  
        aud2 = GameObject.Find("tick").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Vector2 pos = transform.position;
			pos.x = Mathf.Round (pos.x);
			pos.y = Mathf.Round (pos.y);
            aud2.Play();

            Instantiate (bombPrefab, pos, Quaternion.identity);
           

        }
	}
}
