using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {   
        transform.position += Vector3.left * speed * Time.deltaTime;

    }

  
}
