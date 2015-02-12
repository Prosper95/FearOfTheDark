using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	
	void OnGUI () {
		if(GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 10, 100, 50), "Main Menu")) {
			// This code is executed when the Button is clicked
			Application.LoadLevel ("FearOfTheDarkMenu");
			
		}
	}
}
