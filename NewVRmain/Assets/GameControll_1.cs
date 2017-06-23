using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameControll_1 : MonoBehaviour {
	//defining conotrolller
	public static GameControll_1 control;

	void Awake(){
		control = this;
		DontDestroyOnLoad (this);
	}
	// Use this for initialization
	void Start () {
		// load level 1 messed up on the name
		StartCoroutine (LoadLevel ("Start_Menu"));
	}
	//load a scene passing a scene name
	public IEnumerator LoadLevel(string sceneName){
		//waiting for curren tframe to end
		yield return new WaitForEndOfFrame();
		//load the scene
		SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
		//unload previous scene
		StartCoroutine (unLoadLevels (sceneName));
	}

	private IEnumerator unLoadLevels(string exception){
		yield return new WaitForEndOfFrame ();
		//for each scene currently loaded
		for (int i = 0; i < SceneManager.sceneCount; i++) {
			//checking to make sure scene is not main scene or exception
			if (SceneManager.GetSceneAt (i).name != exception && SceneManager.GetSceneAt (i).name != "scene1") {//mixedup my vrmain scene and  scene1
				//if its not main scene or newly loaded scene unload it.
				//DontDestroyOnLoad(this);
				SceneManager.UnloadScene (SceneManager.GetSceneAt (i).name);
			}

		}
	}
}