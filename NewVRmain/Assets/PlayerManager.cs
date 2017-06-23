
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

	public static int health = 100;
	public Slider healthBar;

	void start()
	{
		//InvokeRepeating ("constantHealthIncrease", 1, 1);
	}

	void Update()
	{
		healthBar.value = health;

	}

	void constantHealthIncrease()
	{
		/*if (health < 100) {
 	 	 health += 2;
 	 }
 	 ?
 	 */

		health = health - 20;
		healthBar.value = health;
	}

	public void SantaHit(int damage)
	{
		if (health == 0) {
			PlayerPrefs.SetString ("level", SceneManager.GetActiveScene ().name);
			PlayerPrefs.Save ();
			health = 100;
			Lives.lives--;
			if (Lives.lives == 0)
			{
				Lives.lives = 3;
				SceneManager.LoadScene("Restart_Game");
			}
			else
			{
				SceneManager.LoadScene("Restart_Level");
			}
		} else {
			health -= damage;
		}

	}
}
