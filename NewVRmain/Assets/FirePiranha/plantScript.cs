using UnityEngine;
using System.Collections;

public class plantScript : MonoBehaviour {

	public Rigidbody fireball2;
	public Transform mouthLocation;
	public GameObject player;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("x")) {

		}

	}

	void OnTriggerEnter(Collider col) {
		StopCoroutine ("shoot");
		StartCoroutine ("shoot");
	}

}
