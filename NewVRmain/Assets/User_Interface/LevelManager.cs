using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {
    public void LoadScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("level"));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

	public void loadIntro(string name) {
		SceneManager.LoadScene(name);
	}

    public void RestartGame()
    {
        SceneManager.LoadScene("Start_Menu");
    }

	void LeaveGame() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
