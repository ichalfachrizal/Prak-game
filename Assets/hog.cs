using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class hog : MonoBehaviour {
	public AudioClip jump;
	public AudioClip leftright;
	public Text score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.Space)) {
			audio.clip=jump;
			audio.Play();
			GetComponent <Rigidbody> ().velocity = Vector3.zero;
			GetComponent <Rigidbody> ().AddForce (Vector3.up * 350);
		}
		if (Input.GetKeyDown (KeyCode.RightControl)) {
			audio.clip=leftright;
			audio.Play ();
			GetComponent <Rigidbody> ().velocity = Vector3.zero;
			GetComponent <Rigidbody> ().AddForce (Vector3.right * 300);
		}
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			audio.clip=leftright;
			audio.Play ();
			GetComponent <Rigidbody> ().velocity = Vector3.zero;
			GetComponent <Rigidbody> ().AddForce (Vector3.left * 300);
		}
	}


	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "point") {
		other.gameObject.audio.Play ();
			int point = int.Parse (score.text) + 10;
			score.text = point.ToString ();
			Destroy (other.gameObject);	
				}
	}
		

	void OnCollisionExit(Collision other){
			//Debug.Log('terlepas')
			if (other.gameObject.tag=="point")
				other.gameObject.audio.Play();
	}

	//void OnCollisionEnter(Collision other){
		//if(other.gameObject.tag == "boxpoint"){
		
	//}
	//}
}