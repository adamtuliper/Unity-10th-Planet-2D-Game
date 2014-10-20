using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class startgame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Restartgame() {
		// restart the loaded level.
		Application.LoadLevel("001");
	}

}
