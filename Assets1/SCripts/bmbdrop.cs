using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bmbdrop : MonoBehaviour
{
    public AudioSource aud2;
    public GameObject bomb;
    void Start()
    {
        aud2 = GameObject.Find("tick").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = transform.position;
            pos.x = Mathf.Round(pos.x);
            pos.y = Mathf.Round(pos.y);
            aud2.Play();
            Instantiate(bomb, pos, Quaternion.identity);
        }
    }
}
