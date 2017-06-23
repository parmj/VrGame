using UnityEngine;
using System.Collections;

public class pipeTriggerScript : MonoBehaviour {

	public GameObject spears;
	// Use this for initialization
	void Start () {
		spears = GameObject.Find ("Spears");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		spears.GetComponent<Animation> ().Play();
		this.gameObject.GetComponent<AudioSource> ().Play ();
		print ("scored");
	}
}
