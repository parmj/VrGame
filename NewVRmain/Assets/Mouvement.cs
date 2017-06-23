using UnityEngine;
using System.Collections;

public class Mouvement : MonoBehaviour {

	private GameObject ground;
	private bool move = false;
	private Rigidbody rb;

	public GameObject prefab;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (.5f, .5f, 0));
		RaycastHit hit;

		if (move) {

			transform.position = transform.position + Camera.main.transform.forward * 1f * Time.deltaTime;
		}

		if (Physics.Raycast (ray, out hit)) {

			if (hit.collider.name.Contains ("plane")) {

				move = false;
			} 
			else {
				
				move = true;
			}
		}


		/*
		if(Input.GetButtonDown("Fire1")){

			throwBall (prefab);

		}
*/
		if(Input.GetButtonDown("Jump"))
			{
				rb.velocity = new Vector3 (0, 5, 0);
			}


	}

	public void throwBall(GameObject snow)
	{
		GameObject ball = Instantiate(snow) as GameObject;		
		ball.transform.position = transform.position + Camera.main.transform.forward ;
		Rigidbody rb = ball.GetComponent<Rigidbody>();
		rb.velocity = Camera.main.transform.forward * 15;

		
	}
		
}
