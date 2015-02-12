using UnityEngine;
using System.Collections;

public class GUIButton : MonoBehaviour {
	

	void OnGUI () {
		if(GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 10, 100, 50), "Play Game!")) {
			// This code is executed when the Button is clicked
			Application.LoadLevel ("Scene");

		}
	}
}
