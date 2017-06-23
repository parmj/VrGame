using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {

    private int lifeCounter;
    private Text theText;
	// Use this for initialization
	void Start () {
        theText = GetComponent<Text>();
        lifeCounter = Lives.lives;
	}
	
	// Update is called once per frame
	void Update () {
        theText.text = "" + lifeCounter;
	}
}
