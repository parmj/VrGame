using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class platformColiderScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.transform.position.y < 1200 && Application.loadedLevelName == "platform") {
			this.gameObject.transform.position = new Vector3 (-3467, 1264, 4298);
		} else if (this.gameObject.transform.position.y < 1200) {
			this.gameObject.transform.position = new Vector3 (-3537, 1255, 4237);
			PlayerPrefs.SetString("level", SceneManager.GetActiveScene().name);
			PlayerPrefs.Save();
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
		}
	}
}
