using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
	
	public float fSpeed;
	private GameObject Player;
	private GameObject Barriers;
	private Vector3 v3MoveDirection = Vector3.zero;
	
	
	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		v3MoveDirection = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		v3MoveDirection = Player.transform.position - this.gameObject.transform.position ;
		transform.position += (v3MoveDirection*fSpeed*Time.deltaTime);
		if(Movement.health <= 0) Destroy (this.gameObject);
	}
	
	void OnTriggerEnter(Collider c) {
		if (c.gameObject.tag == "Player") {
			Destroy(this.gameObject);
			Movement.health -= 5;
		}
		if(c.gameObject.tag == "Bullet") {
			Destroy (this.gameObject);
			print ("Bullet");
		}
		print (c.gameObject.tag);
	}
	
}
