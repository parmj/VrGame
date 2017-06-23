using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour {

    float timeRemaining = 20;   //Pre-earned time
    float timeExtension = 6f;   //time to extend by on collecting powerup
    float timeDeduction = 5f;   //time to reduce, on collecting the snag
    float totalTimeElapsed = 0;
    float score = 0f;      //total score
	public bool isGameOver = true;
	public string nextLevel;
    public void PowerupCollected()
    {
        timeRemaining += timeExtension;   //add time to the time remaining
    }

    public void AlcoholCollected()
    {
        timeRemaining -= timeDeduction;   // deduct time
    }

    void Update()
    {
		if (isGameOver){     //check if isGameOver is true
			return;      //move out of the function
		}

            totalTimeElapsed += Time.deltaTime;
            score = totalTimeElapsed * 100;  //calculate the score based on total time elapsed
            timeRemaining -= Time.deltaTime; //decrement the time remaining by 1 sec every update
            if (score >= 4000)
            {
			SceneManager.LoadScene ("platform");
			//gameObject.GetComponent<leveLoader> ().loadLevel (nextLevel);
            } else if (timeRemaining <= 0)
            {
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
			}            }
        }
    

    void OnGUI()
    {
        //check if game is not over, if so, display the score and the time left
        if (!isGameOver)
        {
            GUI.Label(new Rect(10, 10, Screen.width / 5, Screen.height / 6), "TIME LEFT: " + ((int)timeRemaining).ToString());
            GUI.Label(new Rect(Screen.width - (Screen.width / 6), 10, Screen.width / 6, Screen.height / 6), "SCORE: " + ((int)score).ToString());
        }
    }
}
