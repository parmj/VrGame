using UnityEngine;
using System.Collections;

public class pengumouth : MonoBehaviour {

	public GameObject prefab;

	public float targetDistance;
	public float attackDistance;
	public Transform santa;
	public float shootTimer = 0;

	public float period = 0f;

	public GameObject pingu;
	int multiple = 0;

	private    float timer = 0.0f;

	int choice = 1;



	// Update is called once per frame
	void Update () {


		int timeValue = 10;
		int prevTimeValue = 0;
		int pinguHealth = pingu.GetComponent<Pingu> ().getHealth ();

		if (pinguHealth != 0) {


			if (choice == 1) {


				timer += Time.deltaTime;

				if (timer <= timeValue) {
					throwBall (prefab);
				} else {
					choice = 2;
				}
			} 

			if (choice == 2) {

				timer += Time.deltaTime;

				if (timer <= timeValue + 25) {
					pingu.GetComponent<Pingu> ().sidetoside ();
				} else {
					choice = 3;
					pingu.GetComponent<Pingu> ().setCurrent (0);

				}

			}

			if (choice == 3) {
				timer += Time.deltaTime;

				if (timer <= timeValue + (35 + multiple)) {
					pingu.GetComponent<Pingu> ().jump ();
				} else {
					choice = 1;
					pingu.GetComponent<Pingu> ().setCurrent (0);
					timer = 0;
					multiple -= 2;
				}

			}
		}//end big if

	}

	public void throwBall(GameObject snow)
	{
		int count = 0;

		//Debug.Log ("Health is " + pinguHealth);



		if (shootTimer == 60) {

			pingu.GetComponent<Animation> ().Play ("beakOpen");
			while (count < 250) {
				count++;
			}
			GameObject ball = Instantiate (snow) as GameObject;	 	 
			ball.transform.position = transform.position;
			Rigidbody snowballrb = ball.GetComponent<Rigidbody> ();
			snowballrb.velocity = Camera.main.transform.forward * -30;
			shootTimer = 0;
		}

		shootTimer++;
	}



}
