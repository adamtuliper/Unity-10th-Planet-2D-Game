

var otherpref: GameObject;
var fuelcan : GameObject;
var lazer: GameObject;

function OnTriggerEnter2D (other: Collider2D) {

	//			
	var spawncan: int = Random.Range(0, 2);
	if (spawncan == 0)
	{ 
	fuelcan.SetActive (false);
	lazer.SetActive (true);
	}
	
	if (spawncan == 1)
	{ 
	fuelcan.SetActive (true);
	lazer.SetActive (false);
	}



	otherpref.transform.position.x = otherpref.transform.position.x + (72);
	otherpref.transform.position.y = 0;

	
	
		

	
}


