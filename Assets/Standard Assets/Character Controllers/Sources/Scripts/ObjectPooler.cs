using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ObjectPooler : MonoBehaviour {

	private static volatile ObjectPooler pool;

	private Dictionary<String, ObjectPool> objectPools;

	private static object syncRoot = new System.Object();

	private ObjectPooler() {
		this.objectPools = new Dictionary<String, ObjectPool> ();
	}

	public static ObjectPooler Instance {
		get {
			if(pool == null) {
				lock(syncRoot) {
					if(pool == null)
						pool = new ObjectPooler();
				}
			}
			return pool;
		}
	}

	public static bool CreatePool(GameObject objToPool, int initialPoolSize, int maxPoolSize) {
		if(ObjectPooler.Instance.objectPools.ContainsKey(objToPool.name)) return false;
		else {
			ObjectPool nPool = new ObjectPool(objToPool, initialPoolSize, maxPoolSize);
			ObjectPooler.Instance.objectPools.Add (objToPool.name, nPool);
			Debug.Log (objToPool.GetType ().ToString());
			return true;
		}
	}

	public static GameObject GetObject(GameObject obj) {
		return ObjectPooler.Instance.objectPools[obj.name].GetObject();
	}
}