using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour
{
	void Update() {
			Vector3 mousePos = Input.mousePosition;
			mousePos = Camera.main.ScreenToWorldPoint(mousePos);
			Vector3 dir = mousePos - transform.position;
			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		this.gameObject.transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
	}
}
