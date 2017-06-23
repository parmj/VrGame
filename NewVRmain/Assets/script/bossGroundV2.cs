using UnityEngine;
using System.Collections;

public class bossGroundV2 : MonoBehaviour {

	// Use this for initialization
	int choice = 2;
	float timer = 0;
	int count = 0;

	void Start()
	{
		InvokeRepeating ("movePlatform", 20f, 20f);
	}
	void movePlatform()
	{	
		
		if (choice == 1) {
				playleft ();
			choice = Random.Range(1,3);

		} //if choice 1
	
		else if (choice == 2) {

				playRight ();
				choice = Random.Range(1,3);
		}//if choice 2


	}

	public void playleft()
	{
		this.gameObject.GetComponent<Animation> ().Play ("leftShake");

	}
	public void playRight()
	{
		this.gameObject.GetComponent<Animation> ().Play ("rightShake");

	}

}
