using UnityEngine;
using System.Collections;

public class UFOSpinner : MonoBehaviour {

	public float passiveRotationSpeed;

	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate( new Vector3( 0f, passiveRotationSpeed * Time.deltaTime, 0f) );

	}
}
