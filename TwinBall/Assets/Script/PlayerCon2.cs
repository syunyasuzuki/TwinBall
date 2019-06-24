﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon2 : MonoBehaviour {

    public float speed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

    }
}
