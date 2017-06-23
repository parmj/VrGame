using UnityEngine;
using System.Collections;

public class fireballScript : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("FirstPersonCharacter");
		Destroy (this.gameObject, 3);

	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (player.transform);
		transform.rotation *= Quaternion.Euler (90, 0, 0);

	}
		
}
