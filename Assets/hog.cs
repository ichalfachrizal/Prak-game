using UnityEngine;
using System.Collections;

public class hog : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent <Rigidbody> ().velocity = Vector3.zero;
			GetComponent <Rigidbody> ().AddForce (Vector3.up * 350);
		}
		if (Input.GetKeyDown (KeyCode.RightControl)) {
			GetComponent <Rigidbody> ().velocity = Vector3.zero;
			GetComponent <Rigidbody> ().AddForce (Vector3.right * 300);
		}
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			GetComponent <Rigidbody> ().velocity = Vector3.zero;
			GetComponent <Rigidbody> ().AddForce (Vector3.left * 300);
		}
	}
}
