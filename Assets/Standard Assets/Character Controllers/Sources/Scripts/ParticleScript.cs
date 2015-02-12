using UnityEngine;
using System.Collections;

public class ParticleScript : MonoBehaviour {
	public GameObject ParticleSystem;
	public GameObject Player;
	public float fSpeed;
	private Vector3 v3MoveDirection = Vector3.zero;
	private bool fire;

	// Use this for initialization
	void Start () {
		fire = false;
		Player = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () {
		fire = Input.GetMouseButtonDown (0);
		//if(fire) 
		//v3MoveDirection = Input.mousePosition - Player.transform.position; 
		//transform.position += (v3MoveDirection*fSpeed*Time.deltaTime);

	}
}
