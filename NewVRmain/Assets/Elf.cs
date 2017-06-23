
using UnityEngine;
using System.Collections;

public class Elf : MonoBehaviour {

	public GameObject prefab;

	public float targetDistance;
	public float attackDistance;
	public Transform santa;
	public float shootTimer = 0;

	private float nextActionTime = 0f;
	public float period = 0f;

	public Rigidbody rb;
	public Renderer myRen;

	public int health;

	// Use this for initialization
	void Start () {

		myRen = GetComponent<Renderer> ();
		rb = GetComponent<Rigidbody>();
		health = 100;

	}

	// Update is called once per frame
	void Update () {
		targetDistance = Vector3.Distance (santa.position, transform.position);
		if (targetDistance < attackDistance) {

			lookAtSAnta ();

			myRen.material.color = Color.red;

			if (Time.time > nextActionTime ) 
			{ 
				nextActionTime = Time.time + period;
				throwBall (prefab);
			} 


		}

		if (health == 0) {
			Destroy (this.gameObject);
		} 

	}


	private void lookAtSAnta()
	{
		transform.Rotate (new Vector3 (0, Time.deltaTime * 100, 0));
	}



	public void throwBall(GameObject snow)
	{

		if (shootTimer == 10) {
			GameObject ball = Instantiate (snow) as GameObject;	 	 
			ball.transform.position = transform.position;
			Rigidbody snowballrb = ball.GetComponent<Rigidbody> ();
			snowballrb.velocity = Camera.main.transform.forward * -30;
			shootTimer = 0;
		}

		shootTimer++;
	}


	public void Hit(int damage)
	{
		if (health == 0) {
			Destroy (this.gameObject);
		} else {
			health -= damage;
		}
	}

}
