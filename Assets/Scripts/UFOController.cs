﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UFOController : MonoBehaviour {

	public float maxSpeed;
	public float passiveRotationSpeed;
	public List<GameObject> itemsRequired;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Rotate( new Vector3( 0f, passiveRotationSpeed * Time.deltaTime, 0f) );
		handlePlayerControl();

	}

	void handlePlayerControl() {
		// Move forward based on input
		if( Input.GetKey( KeyCode.W ) ) {
			transform.position += new Vector3( 0f, 0f, maxSpeed * Time.deltaTime);
		}
		
		// Move backward based on input
		if( Input.GetKey( KeyCode.S ) ) {
			transform.position += new Vector3( 0f, 0f, -maxSpeed * Time.deltaTime);
		}
		
		// Move left based on input
		if( Input.GetKey( KeyCode.A ) ) {
			transform.position += new Vector3( -maxSpeed * Time.deltaTime, 0f, 0f);
		}
		
		// Move right based on input
		if( Input.GetKey( KeyCode.D ) ) {
			transform.position += new Vector3( maxSpeed * Time.deltaTime, 0f, 0f);
		}
	}

	bool tryToAbductObject() {
		if( 
		return false;
	}
}
