using UnityEngine;
using System.Collections;

public class skyboxchanger : MonoBehaviour {
	public Material skybox;
	// Use this for initialization

	void Start () {
		RenderSettings.skybox = skybox;
	}
	

}
