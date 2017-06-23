using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
public class audioOnclick : MonoBehaviour {
	public AudioSource source;
	public AudioClip clip;
	void start(){
		source = GetComponent<AudioSource> ();
		//clip = GetComponent<AudioClip> ();
	}

	// Use this for initialization
	public void OnTriggerEnter(Collider other){
		source.Play ();

	}
}
