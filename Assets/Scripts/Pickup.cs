using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//This script destroys an object when the player picks it.(collides with it).
public class Pickup : MonoBehaviour
{

	public Text scoretext;						// The amount of cans we wil pick up
	private float score; 
	public Text scoretextfinal;
	public GameObject particle ;
	public AudioClip CollectSound ;


	//This method is called when an object (with RigidBody2D and Collider2D) collides with this
	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player collided with a fuel can
		if(col.gameObject.tag == "Can")
		{
			//Destroy the object(the one with this script attached) from the scene.	
			//Destroy (col.gameObject);
			col.gameObject.SetActive (false);
			// give a score
			score++;
			// 
			scoretext.text = "" + score;
			scoretextfinal.text = "" + score;
			audio.PlayOneShot(CollectSound);
			Instantiate (particle, col.transform.position, col.transform.rotation );

		}



	}
}