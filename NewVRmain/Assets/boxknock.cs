using UnityEngine;
using System.Collections;

public class boxknock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float h = Input.GetAxis ("Fire1");
		float v = Input.GetAxis ("Fire2");
		transform.position += new Vector3  (h * .9f, v * .9f, 0f);
	}
}
