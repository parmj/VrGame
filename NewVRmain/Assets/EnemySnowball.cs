
using UnityEngine;
using System.Collections;

public class EnemySnowball : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "MainCamera") {
			other.gameObject.GetComponent<PlayerManager> ().SantaHit (20);
		}
		Destroy (this.gameObject, 4);

	}
}
