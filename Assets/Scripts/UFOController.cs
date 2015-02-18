using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class UFOController : MonoBehaviour {

	public float maxSpeed;
	public Transform beam;

	public GameObject bootyAlert;
	public Text spaceAlert;
	public Text distanceTextbox;
	public Text bootyAmountTextbox;

	public List<Transform> treasures;

	private int bootyCollected;
	private bool isUnderTreasure;
	private GameObject targetedTreasure = null;

	public void areUnderTreasure( GameObject treasure ) {
		targetedTreasure = treasure;
		isUnderTreasure = true;
	}

	public void areNotUnderTreasure() {
		targetedTreasure = null;
		isUnderTreasure = false;
	}


	// Use this for initialization
	void Start () {
		isUnderTreasure = false;
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

		if( Input.GetKey( KeyCode.Space ) && isUnderTreasure ) {
			collectBooty();
		}
	}

	bool tryToAbductObject() {
		return false;
	}

	void updateTextDisplay() {
		// find nearest object
		// if close, 
		// total booty collected
		//

	}

	void updateDistanceDisplay() {
		string top = "on top of yee";
		float topRadius = 4f;
		string veryClose = "so very close";
		float veryCloseRadius = 10f;
		string close = "nearby";
		float cCloseRadius = 50f;
		string normal = "a moderete distance away";
		float normalRadius = 100f;
		string far = "far away";


	}

	void collectBooty() {
		if( targetedTreasure != null ){
			bootyCollected++;
			bootyAlert.SetActive( true );
			targetedTreasure.SetActive( false );
			areNotUnderTreasure();
		}
		else {
			Debug.Log("sick treasure error bro");
		}
	}

}
