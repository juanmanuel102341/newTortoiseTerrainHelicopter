using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	private Rigidbody rb;
	public float velocity;
	// Use this for initialization
	void Start () {
		rb=GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){

			rb.transform.Rotate(Vector3.up*-velocity*Time.deltaTime);
		}else if(Input.GetKey(KeyCode.D)){
			rb.transform.Rotate(Vector3.up*velocity*Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.W)){
			rb.transform.Translate(Vector3.back*velocity*Time.deltaTime);

		}else if(Input.GetKey(KeyCode.S)){
			rb.transform.Translate(Vector3.forward*velocity*Time.deltaTime);
		}
	}
}
