using UnityEngine;
using System.Collections;

public class mouth1 : MonoBehaviour {

	public GameObject prefab;

	public float targetDistance;
	public float attackDistance;
	public Transform santa;
	public float shootTimer = 0;

	private float nextActionTime = 0f;
	public float period = 0f;

	public GameObject pingu;



	// Update is called once per frame
	void Update () {

		throwBall (prefab);

	}

	public void throwBall(GameObject snow)
	{
		int count = 0;
		if (shootTimer == 30) {
			
			pingu.GetComponent<Animation> ().Play ("beakOpen");
			while (count < 200) {
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
