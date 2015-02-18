using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Flasher : MonoBehaviour {

	public float flashDuration;
	public int numFlashes;

	private float flashTimer = 0f;
	private int numFlashesTimer = 0;

	// Use this for initialization
	void Start () {
		reset();
	}
	
	// Update is called once per frame
	void Update () {
		flashTimer += Time.deltaTime;
		if( flashTimer >= flashDuration ) {
			flashTimer = 0;
			toggleVisible();
			numFlashesTimer++;
			if( numFlashesTimer >= numFlashes ) {
				gameObject.SetActive( false );
			}
		}
	}

	void toggleVisible() {
		if( gameObject.GetComponent<Text>().enabled ){
			gameObject.GetComponent<Text>().enabled = false;
		}
		else {
			gameObject.GetComponent<Text>().enabled = true;
		}
	}

	void reset() {
		gameObject.GetComponent<Text>().enabled = true;
		flashTimer = 0f;
		numFlashesTimer = 0;
	}
}
