
using UnityEngine;
using System.Collections;

public class ElfMove : MonoBehaviour {
	bool found = false;
	public float targetDistance;
	public float attackDistance;
	public Transform santa;

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

		if (targetDistance < attackDistance || found) {
			found = true;
			findSanta();
			myRen.material.color = Color.red;
		}


	}

	void findSanta()
	{
		transform.LookAt (santa.GetComponent<Transform> ());
		transform.position = Vector3.MoveTowards (transform.position, santa.position, 0.9f*Time.deltaTime);
	}



	public void Hit2(int damage)
	{
		if (health <= 0) {
			Destroy (this.gameObject);
		} else {
			health -= damage;
		}
	}

void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "MainCamera") {
			other.gameObject.GetComponent<PlayerManager> ().SantaHit (20);
			Destroy (this.gameObject);
		}
}
}