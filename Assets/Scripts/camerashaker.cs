using UnityEngine;
using System.Collections;

public class camerashaker : MonoBehaviour {


	public Animator anim;					// The animator that controls the camera animations

	// Update is called once per frame
	void Shakeit () {

		print ("shakeit");
		anim.SetTrigger("shake");
	
	
	}
}
