using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombspawn : MonoBehaviour
{
    public AudioSource aud3;
    public GameObject bomb;
     void Start()
    {
        aud3 = GameObject.Find("tick").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 pos = new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
            aud3.Play();
            Instantiate(bomb, pos, Quaternion.identity);
        }
    }
}
