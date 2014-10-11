using UnityEngine;
using System.Collections.Generic;


public class ObjectPool : MonoBehaviour {

	private List<GameObject> pool;
	private GameObject pooledObj;
	private int initialSize;
	private int maxSize;

	/** Construct the ObjectPool to create a List of GameObjects and instantiate the pooledObject passed in each slot */
	public ObjectPool(GameObject pooledObj, int initialSize, int maxSize) {
		pool = new List<GameObject> ();

		this.pooledObj = pooledObj;
		this.initialSize = initialSize;
		this.maxSize = maxSize;

		for(int i = 0; i < initialSize; i++) {
			GameObject newObj = GameObject.Instantiate (pooledObj, Vector3.zero, Quaternion.identity) as GameObject;
			newObj.SetActive(false);
			pool.Add(newObj);
		}
	}

	/** Get the next GameObject available to be used in the pool
	    We can also increase the size of the pool if none are available */
	public GameObject GetObject() {
		GameObject returnObj = null;

		for(int i = 0; i < pool.Count; i++) {
			if(!pool[i].activeSelf) {
				pool[i].SetActive (true);
				returnObj = pool[i];
				return returnObj;
			}
		}

		if(returnObj == null) {
			if(this.maxSize > this.pool.Count) {
				GameObject newObj = GameObject.Instantiate (pooledObj, Vector3.zero, Quaternion.identity) as GameObject;
				newObj.SetActive(false);
				pool.Add(newObj);
				returnObj = newObj;
			}
		}

		return returnObj;
	}

	/** Set Object to inactive */
	public void SetObjectInactive(GameObject obj) {
		obj.SetActive (false);
	}

	/** Get the Object Type we're pooling */
	public System.Type GetPooledObjectType() {
		return pooledObj.GetType ();
	}
}
