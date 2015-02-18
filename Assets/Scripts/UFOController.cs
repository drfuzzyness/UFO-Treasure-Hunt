using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class UFOController : MonoBehaviour {

	public float maxSpeed;
	public Transform beam;

	public GameObject bootyAlert;
	public GameObject spaceAlert;
	public Text distanceTextbox;

	public Transform theTreasure;

	private bool canGrabTreasure;
	


	// Use this for initialization
	void Start () {
		canGrabTreasure = false;
	}
	
	// Update is called once per frame
	void Update () {
		handlePlayerControl();
		updateTextDisplay();
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

		if( Input.GetKey( KeyCode.Space ) && canGrabTreasure ) {
			collectBooty();
		}
	}

	bool tryToAbductObject() {
		return false;
	}

	void updateTextDisplay() {
		updateDistanceDisplay();

	}

	void updateDistanceDisplay() {
		float distance = ( theTreasure.position - transform.position ).magnitude;

		if( distance < 50f ) {
			distanceTextbox.text = "on top of it";
			canGrabTreasure = true;
			spaceAlert.SetActive(true);
		} else if( distance < 300f ) {
			spaceAlert.SetActive(false);
			distanceTextbox.text = "so very close";
			canGrabTreasure = false;
		} else if( distance < 500f ) {
			distanceTextbox.text = "nearby";
		} else if( distance < 1000f ) {
			distanceTextbox.text = "a moderete distance away";
		} else {
			distanceTextbox.text = "far away";
		}
 	}

	void collectBooty() {
		bootyAlert.SetActive( true );
		theTreasure.position = new Vector3(0f, 0f, -5000f);
	}

}
