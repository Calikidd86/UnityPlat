﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    /* Normalizes Player Controls */

    public Vector2 moving;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moving.x = moving.y = 0;

        if (Input.GetKey("right")) { moving.x = 1; }
        else if (Input.GetKey("left")) { moving.x = -1; }
        if (Input.GetKey("up")) { moving.y = 1; }
        else if (Input.GetKey("down")) { moving.y = -1; }

	}
}
