using UnityEngine;
using System.Collections;

public class plantScript2 : MonoBehaviour {
	bool insideTigger = false;
	public Rigidbody fireball2;
	public Transform mouthLocation;
	public GameObject player;

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Animation> ().Play ("Armature|ArmatureAction");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	IEnumerator shoot () {
		while (insideTigger) {
			this.gameObject.GetComponent<Animation> ().Play ();
			Rigidbody fireballInstance;
			mouthLocation.LookAt (player.transform);
			yield return new WaitForSeconds (.8f);
			fireballInstance = Instantiate (fireball2, mouthLocation.position, mouthLocation.rotation) as Rigidbody;
			fireballInstance.AddForce (mouthLocation.forward * 500);
			yield return new WaitForSeconds (2.2f);
		}

	}

	void OnTriggerEnter(Collider other) {
		insideTigger = true;


			StopCoroutine (shoot ());
			StartCoroutine (shoot ());
		
	}

	void OnTriggerExit(Collider other) {
		insideTigger = false;
	}

}
