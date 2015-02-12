using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float fSpeed;
	public static int health = 100;
	public static float liberate = 100f;
	public GameObject bullet;
	public GameObject Player;
	private int maxX;
	private int maxY;
	private int minX;
	private int minY;
	private Vector3 v3MoveDirection = Vector3.zero;
	private CharacterController controller;
	public AudioClip shoot;
	
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		Player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Application.LoadLevel ("GameOver");
			Destroy (this.gameObject);
		}
		v3MoveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		v3MoveDirection *= fSpeed;
		controller.Move(v3MoveDirection * Time.deltaTime);
		if(Input.GetMouseButtonDown (0)) {
			audio.PlayOneShot(shoot);
			GameObject.Instantiate(bullet, Player.transform.localPosition, Player.transform.localRotation);	
		}
	}
}
