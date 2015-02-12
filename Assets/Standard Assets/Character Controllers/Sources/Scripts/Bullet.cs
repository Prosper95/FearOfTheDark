using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float velocity;
	private Vector3 vel;
	private int die;
	
	// Use this for initialization
	void Start () {
		//this.gameObject.transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 dir = mousePos - this.transform.position;
		dir /= (Mathf.Sqrt(dir.x * dir.x + dir.y * dir.y + dir.z * dir.z));
		this.vel = velocity * dir;
		vel.z = 0;
		Debug.Log(vel);
	}
	
	// Update is called once per frame
	void Update () {
		if(die > 100) Destroy(this.gameObject);
		//float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		this.transform.position += this.vel * Time.deltaTime;
		die++;
	}
	
	void OnTriggerEnter(Collider c) {
		if(c.gameObject.tag != "Player" && c.gameObject.tag != "Bullet") Destroy(this.gameObject);
		if(c.gameObject.tag == "Enemy") Destroy (c.gameObject);
	}
}
