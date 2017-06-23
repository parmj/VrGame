using UnityEngine;
using System.Collections;

public class leverScript : MonoBehaviour {

	Animation _animation;
	bool isOn = false;
	bool activatedBridge = false;
	Animation bridgeAnimator;

	// Use this for initialization
	void Start () {
		_animation= GetComponent<Animation> ();
		GameObject bridge = GameObject.Find ("drawbridge");
		bridgeAnimator = bridge.GetComponent<Animation> ();
	}

	// Update is called once per frame
	void Update () {
	}

	public void openLever ()
	{

		if (isOn) {
			if (!_animation.isPlaying) {
				this.GetComponent<Animation> ().Play ("Main0");
				isOn = !isOn;
			}
		} else {
			if (!_animation.isPlaying) {
				this.GetComponent<Animation> ().Play ("Main1");
				isOn = !isOn;
				activatedBridge = true;
				this.gameObject.GetComponent<AudioSource> ().Play ();
				bridgeAnimator.Play ("drawBridgeAnimation");
			}
		}
	}
}


