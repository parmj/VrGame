using UnityEngine;
using System.Collections;

public class leverScriptRight : MonoBehaviour {

	Animation _animation;
	bool isOn = false;
	bool activatedStatue = false;
	Animation statueAnimation;

	Component global;

	// Use this for initialization
	void Start () {
		_animation= GetComponent<Animation> ();
		GameObject bridge = GameObject.Find ("penguinRight");
		statueAnimation = bridge.GetComponent<Animation> ();
		global = GameObject.Find("enviro").GetComponent("globalScript");

	}

	// Update is called once per frame
	void Update () {

	}

	public void openRightLever(){

		if (isOn) {
			if (!_animation.isPlaying) {
				this.GetComponent<Animation> ().Play ("Main0");
				isOn = !isOn;

			}
		} else {
			if (!_animation.isPlaying) {
				this.GetComponent<Animation> ().Play ("Main1");
				statueAnimation.Play ("penguinRightAnimation");
				this.gameObject.GetComponent<AudioSource> ().Play ();
				globalScript.penguinsActivated++;
				isOn = !isOn;
			}
		}

	}
}