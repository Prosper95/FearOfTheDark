using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	
	public GameObject spawn;
	
	void start() {
		
	}
	void Update() {
		float r = UnityEngine.Random.value;
		if(r < 0.01 && Movement.health > 0) {
			GameObject.Instantiate (spawn, new Vector3(UnityEngine.Random.insideUnitCircle.x*5, UnityEngine.Random.insideUnitCircle.y*5, 0), Quaternion.identity);
			print ("Spawn");
		}
	}
}
