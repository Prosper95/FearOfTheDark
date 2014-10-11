using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float fSpeed;
	public static int health = 100;
	public static float liberate = 100f;
	private int maxX;
	private int maxY;
	private int minX;
	private int minY;
	private Vector3 v3MoveDirection = Vector3.zero;
	private CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) Destroy (this.gameObject);
		v3MoveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		v3MoveDirection *= fSpeed;
		controller.Move(v3MoveDirection * Time.deltaTime);
	}
}
