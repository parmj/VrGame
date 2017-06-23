using UnityEngine;
using System.Collections;

public class fireballScript2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 3);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision other) 
	{                                                              
		if (other.gameObject.tag == "MainCamera") {
			other.gameObject.GetComponent<PlayerManager>().SantaHit(50);
		}
		Debug.Log ("santa got hit");
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "MainCamera") {
			other.gameObject.GetComponent<PlayerManager>().SantaHit(50);
			Destroy (this.gameObject);
		} 
		Debug.Log ("trigggered");
	}

}
