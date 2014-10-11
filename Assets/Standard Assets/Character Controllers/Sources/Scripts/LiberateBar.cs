using UnityEngine;
using System.Collections;

public class LiberateBar : MonoBehaviour {

	float barDisplay = 1;
	public Vector2 pos = new Vector2(20, 40);
	public Vector2 size = new Vector2(480, 120);
	public Texture2D full;

	void OnGUI() {
		//int offset = (int) (1 - (float) Movement.liberate / 100);
		GUIStyle myStyle = new GUIStyle ();
		myStyle.normal.textColor = Color.black;
		GUI.BeginGroup (new Rect(pos.x, pos.y, size.x*barDisplay, size.y));
		GUI.Box (new Rect(0,0, size.x, size.y), full, myStyle);
		GUI.BeginGroup (new Rect(0,0,size.x, size.y));
		GUI.Box (new Rect (0, 0, size.x, size.y), "Liberate: " + (int) Movement.liberate, myStyle);
		GUI.EndGroup ();
		GUI.EndGroup ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Movement.liberate < 100f) Movement.liberate += 0.05f;
		barDisplay = (float) Movement.liberate/100;
	}
}
