using UnityEngine;
using System.Collections;

public class snowball : MonoBehaviour {
	//Drag in the Bullet Emitter from the Component Inspector.
	public GameObject snowball_emitter;

	//Drag in the Bullet Prefab from the Component Inspector.
	public GameObject snowballs;

	//Enter the Speed of the Bullet from the Component Inspector.
	public float snowballforwardForce;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown("left shift"))
		{
			//The Bullet instantiation happens here.
			GameObject Temporary_Bullet_Handler;
			Temporary_Bullet_Handler = Instantiate(snowballs,snowball_emitter.transform.position,snowball_emitter.transform.rotation) as GameObject;

			//Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
			//This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
			//Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

			//Retrieve the Rigidbody component from the instantiated Bullet and control it.
			Rigidbody Temporary_RigidBody;
			Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
            //Temporary_RigidBody.AddForce(transform.forward * snowballforwardForce);
            Temporary_RigidBody.velocity = Camera.main.transform.forward * 15 ;
            //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
            Destroy(Temporary_Bullet_Handler, 10.0f);
		}
	}
}