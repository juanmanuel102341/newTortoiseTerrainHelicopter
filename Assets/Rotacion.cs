﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour {
	public float velocity;
	private Transform tf;
	// Use this for initialization
	void Start () {
		tf=GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
		tf.transform.Rotate(Vector3.forward*velocity*Time.deltaTime);	
	}
}
