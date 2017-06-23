using UnityEngine;
using System.Collections;

public class snowballthrow : MonoBehaviour {

	public GameObject prefab;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Fire1")){

			throwBall (prefab);
			//DestroyObject (prefab, 5);
		}
	}


	void throwBall(GameObject snow)
	{
		GameObject ball = Instantiate(snow) as GameObject;		
		ball.transform.position = transform.position + Camera.main.transform.forward ;
		Rigidbody rb = ball.GetComponent<Rigidbody>();
		rb.velocity = Camera.main.transform.forward * 15;


	}
		

}
