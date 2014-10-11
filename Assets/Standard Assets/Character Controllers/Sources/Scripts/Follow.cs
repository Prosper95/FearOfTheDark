using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public float fSpeed;
	public GameObject Enemy;
	public GameObject Player;
	public GameObject Barriers;
	private Vector3 v3MoveDirection = Vector3.zero;


	// Use this for initialization
	void Start () {
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		Player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		v3MoveDirection = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		v3MoveDirection = Player.transform.position - Enemy.transform.position ;
		transform.position += (v3MoveDirection*fSpeed*Time.deltaTime);
	}

	void OnTriggerEnter(Collider c) {
		if (c.gameObject.tag == "Player") {
			this.gameObject.SetActive (false);
			Movement.health -= 5;
		}
	}

}
