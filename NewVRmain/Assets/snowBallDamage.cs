
using UnityEngine;
using System.Collections;

public class snowBallDamage : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.tag == "Elf1") {
			other.gameObject.GetComponent<Elf> ().Hit (50);
		}

		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<ElfMove> ().Hit2 (50);
		}
		if (other.gameObject.tag == "pingu") {
			other.gameObject.GetComponent<Pingu> ().hitPingu (20);
		}


		if(other.gameObject.tag == "lever"){
			other.gameObject.GetComponent<leverScript> ().openLever ();
	}
		if (other.gameObject.tag == "nextStage") {
			string nextstage = other.gameObject.GetComponent<nextLevel> ().nextLevelName;
			other.gameObject.GetComponent<leveLoader> ().loadLevel (nextstage);
		}
		if (other.gameObject.tag == "midLever") {
			
				other.gameObject.GetComponent<leverScriptMid> ().openMidLever ();
			
		}
		if (other.gameObject.tag == "leftLever") {
			other.gameObject.GetComponent<leverScriptLeft> ().openLeftLever ();
		}
		if (other.gameObject.tag == "rightLever") {
			other.gameObject.GetComponent<leverScriptRight> ().openRightLever ();
		}

		Destroy (this.gameObject, 4);
	}
}

