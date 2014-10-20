using UnityEngine;
using System.Collections;

public class characteraudio : MonoBehaviour {

	public AudioClip footstep;
	public AudioClip jump;
	public AudioClip jumpdown;
	
	public void Footset () {
		audio.PlayOneShot(footstep, 10.0F);
	}



	public void Jump () {
		audio.PlayOneShot(jump, 1.0F);
	}

	public void JumpDown () {
		audio.PlayOneShot(jumpdown, 2.0F);
	}
}
