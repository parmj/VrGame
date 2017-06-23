using UnityEngine;
using System.Collections;

public class nextStageColide : MonoBehaviour {

	// Use this for initialization

	void OnTriggerEnter(Collider other){
		string nextstage = gameObject.GetComponent<nextLevel> ().nextLevelName;
		if (other.gameObject.tag == "MainCamera") {
			gameObject.GetComponent<leveLoader> ().loadLevel (nextstage);
		}
	}
}
