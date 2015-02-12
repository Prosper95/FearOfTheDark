using UnityEngine;
using System.Collections;

public class Liberate : MonoBehaviour {
	
	public double min = 3.0;
	public float fSetMin = 3;
	public double max = 17.0;
	public int speed = 20;
	public double curr;
	private bool isLiberating;
	private bool up;
	
	// Use this for initialization
	void Start () {
		isLiberating = false;
		up = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") && Movement.liberate >= 25) {
			isLiberating = true;
			LiberateLight();
		}
		if(isLiberating) LiberateLight ();
		if (!isLiberating) {
			this.GetComponent<Light>().range = fSetMin;
			up = true;
		}
	}
	
	void LiberateLight () {
		if(up) this.GetComponent<Light>().range += (Time.deltaTime * speed);
		else if (!up) this.GetComponent<Light> ().range -= (Time.deltaTime * speed);

		if (this.GetComponent<Light> ().range >= max) up = false;
		else if (this.GetComponent<Light> ().range <= min) {
			isLiberating = !isLiberating;
			Movement.liberate -= 25;
		}
			
	}
}
