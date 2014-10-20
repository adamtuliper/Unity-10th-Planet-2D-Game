using UnityEngine;

//This script acts as a dead zone, so when the Player hits it, the level is reloaded.
public class Respawn : MonoBehaviour
{
	//This method is called when an object (with RigidBody2D and Collider2D) collides with this
	void OnTriggerEnter2D(Collider2D collider)
	{
		// If the player was the one who collided
		if(collider.gameObject.tag == "Player") 
		{	
			//Reload the level (Unity scene)
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}