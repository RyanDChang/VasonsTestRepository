﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {

    public GameObject trackedPlayer;
    public float xMin = -5;
    public float xMax = 5;
    public float yMin = 0;
    public float yMax = 3;
    
	// Use this for initialization
	void Start () {
        trackedPlayer = GameObject.FindGameObjectWithTag ("Player");
        xMin = -5;
        xMax = 5;
        yMin = 0;
        yMax = 3;

    }
	
	// Update is called once per frame
	void LateUpdate () {
        float x = Mathf.Clamp(trackedPlayer.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(trackedPlayer.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
    }
}
