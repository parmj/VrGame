using UnityEngine;
using System.Collections;

public class globalScript : MonoBehaviour {
	public static int penguinsActivated = 0;
	public bool activatedAlready = false;
	GameObject midLever;

	// Use this for initialization

	void Start() {
		midLever = GameObject.Find ("leverMid");
	}
	
	// Update is called once per frame
	void Update () {
		if (penguinsActivated == 2 && !activatedAlready) {
			print ("2 penguins activated");
			activatedAlready = true;
			midLever.GetComponent<leverScriptMid>().enabled = true;


		}
	}
}
