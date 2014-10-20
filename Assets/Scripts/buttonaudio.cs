using UnityEngine;
using System.Collections;

public class buttonaudio : MonoBehaviour {

	public AudioClip click;

	
	public void Clickbutton () {
		audio.PlayOneShot(click, 3.5F);
	}
	
}
