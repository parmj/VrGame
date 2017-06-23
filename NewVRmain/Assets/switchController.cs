using UnityEngine;
using System.Collections;

public class switchController : MonoBehaviour {

	//public GameObject otherObj;

	void Awake () {
	}
	// Use this for initialization
	void Start () {
		

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			print ("space key was pressed");
			gameObject.GetComponent<Animation> ().Play ();
			//otherObj.GetComponent<Animation> ().Play ();
		}
	}
}
