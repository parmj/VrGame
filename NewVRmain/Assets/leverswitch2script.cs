using UnityEngine;
using System.Collections;

public class leverswitch2script : MonoBehaviour {

	Animator animator;

	public IEnumerator PlayOneShot ( string paramName) {
		animator.SetBool (paramName, true);
		yield return null;
	}

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			animator.SetTrigger ("activate");
			print ("changed activated to true");
		}
	}
}
