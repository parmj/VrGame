using UnityEngine;
using System.Collections;

public class snowballCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void playspearAnimation(){
	
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("this shit works");
		if (other.gameObject.tag == "spearColider") {
			//gameObject.GetComponent<snowballCollider>()
		}
	
	}
}
