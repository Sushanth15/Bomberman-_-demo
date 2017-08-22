using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mve : MonoBehaviour
{

    public float speed = 6;

    void FixedUpdate()
    {
        float h = Input.GetAxis("Mouse X")*Time.deltaTime*50;
        float v = Input.GetAxis("Mouse Y") * Time.deltaTime * 50;

        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v) * speed;

        GetComponent<Animator>().SetInteger("x", (int)h);
        GetComponent<Animator>().SetInteger("y", (int)v);
    }
}
