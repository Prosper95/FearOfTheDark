using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	float barDisplay = 1;
	public Vector2 pos = new Vector2(20, 40);
	public Vector2 size = new Vector2(480, 120);
	public Texture2D full;

	void OnGUI() {
		GUIStyle myStyle = new GUIStyle ();

		GUI.BeginGroup (new Rect(pos.x, pos.y, size.x*barDisplay, size.y));
		GUI.Box (new Rect(0,0, size.x, size.y), full, myStyle);
		GUI.BeginGroup (new Rect(0,0,size.x, size.y));
		GUI.Box (new Rect (0, 0, size.x, size.y), "Health: " + Movement.health, myStyle);
		GUI.EndGroup ();
		GUI.EndGroup ();
	}
	
	// Update is called once per frame
	void Update () {
			barDisplay = (float) Movement.health/100;
	}
}
