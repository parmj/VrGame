using UnityEngine;
using System.Collections;

public class leverScriptMid : MonoBehaviour {

	Animation _animation;
	bool isOn = false;
	bool activatedStatue = false;
	Animation statueAnimation;
	Animation doorAnimation;

	Component global;

	// Use this for initialization
	void Start () {
		_animation= GetComponent<Animation> ();
		GameObject bridge = GameObject.Find ("penguinMid");
		statueAnimation = bridge.GetComponent<Animation> ();
		doorAnimation = GameObject.Find ("door").GetComponent<Animation> ();
		global = GameObject.Find("enviro").GetComponent("globalScript");

	}

	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator openDoor() {
		yield return new WaitForSeconds (10);
		doorAnimation.Play ();
	}

public void openMidLever (){
		 bool j = gameObject.GetComponent<globalScript> ().activatedAlready;
		if(j){
		if (isOn) {
			if (!_animation.isPlaying) {
				this.GetComponent<Animation> ().Play ("Main0");
				isOn = !isOn;

			}
		} else {
			if (!_animation.isPlaying) {
				this.GetComponent<Animation> ().Play ("Main1");
				statueAnimation.Play ("penguinMidAnimation");
				this.gameObject.GetComponent<AudioSource> ().Play ();
				globalScript.penguinsActivated++;
				StartCoroutine (openDoor ());
				isOn = !isOn;
			}
		}
	}

}
}
