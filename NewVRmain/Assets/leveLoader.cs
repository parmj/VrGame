using UnityEngine;
using System.Collections;

public class leveLoader : MonoBehaviour {

	public void loadLevel(string leveltoLoad){
		StartCoroutine (GameControll_1.control.LoadLevel (leveltoLoad));
//		Camera.main.transform.TransformDirection = new Vector3 (0, 0, 0);
	}
}
