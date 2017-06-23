using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Pingu : MonoBehaviour {

	public int health;
	public Slider healthBar;
	public GameObject fireball2;
	public Transform mouthLocation;
	public GameObject player;
	private Rigidbody rb;
	public int onGround = 0;

	public AudioClip penguinGotHit;
	public AudioClip penguinDeath;
	public AudioSource audio;

	//side to side function 
	int maxValue = -3530; // or whatever you want the max value to be
	int minValue = -3543; // or whatever you want the min value to be
	int minValuejump = 1255;
	int maxValuejump = 1257;
	int direction = 1; 
	float currentValue = 0f;
	float currentValueJump = 0f;




	// Use this for initialization
	void Start () {

		health = 100;
		rb = GetComponent<Rigidbody> ();
		audio = GetComponent<AudioSource> ();

	}
	void update()
	{
		healthBar.value = health;


	}

	// Update is called once per frame

	public void hitPingu(int damage)
	{
		if (health > 0) {

			this.gameObject.GetComponent<Animation> ().Play ("stun");
			audio.PlayOneShot (penguinGotHit, 0.7f);
			health -= damage;
		}
		else if (health <= 0) {

			this.gameObject.GetComponent<Animation> ().Play ("death");
			audio.PlayOneShot (penguinDeath, 0.7f);
			StartCoroutine (ExecuteAfterTime (3));
		}	healthBar.value = health;
	}

	IEnumerator ExecuteAfterTime (float time) {
		yield return new WaitForSeconds(time);
		SceneManager.LoadScene("Ending");
	}


	public void sidetoside()
	{

		int speed = 2;
		this.gameObject.GetComponent<Animation> ().Play ("waddle");
		currentValue += Time.deltaTime * direction * speed; // or however you are incrementing the position

		if (currentValue <= minValue){
			direction *= -1; 
			currentValue = minValue;
		}
		else if(currentValue >= maxValue) {
			direction *= -1;
			currentValue = maxValue;
		} 
		transform.position = new Vector3( currentValue, transform.position.y, transform.position.z);


	}
	public void jump()
	{
		//this.gameObject.GetComponent<Animation> ().Play ("waddle");
		//rb.velocity = new Vector3 (0, 5, 0);


		int speed = 2;

		currentValueJump += Time.deltaTime * direction * speed; // or however you are incrementing the position
		if(currentValueJump >= maxValuejump) {
			direction *= -1;
			currentValueJump = maxValuejump;
		} else if (currentValueJump <= minValuejump){
			direction *= -1; 
			currentValueJump = minValuejump;
		}
		transform.position = new Vector3( transform.position.x, currentValueJump, transform.position.z);
		this.gameObject.GetComponent<Animation> ().Play ("waddle");
		maxValue = Mathf.RoundToInt (transform.position.x);
	}

	public void setCurrent(int temp)
	{
		currentValue = temp;	
	}
	public int getHealth()
	{
		return health;
	}

}