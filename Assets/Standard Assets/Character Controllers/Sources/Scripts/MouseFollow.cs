using UnityEngine;
using System.Collections;

public class MouseFollow : MonoBehaviour {

	public GameObject Player;
	public float speed = 5f;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown (0)) FollowMousePosition();
	}

	void FollowMousePosition() {
		Vector3 mousePos = Input.mousePosition - Vector3.zero;
		Vector3 angelPos = Player.transform.position - Vector3.zero;
		float angle = Vector3.Angle (mousePos, angelPos);
		this.gameObject.transform.Rotate (new Vector3 (0,angle,0));
	}
}
