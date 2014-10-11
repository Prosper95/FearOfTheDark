using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public GameObject ObjectToPool;
	public int PoolSize;

	private static volatile ObjectPool EnemyPool;

	void start() {
		EnemyPool = new ObjectPool (ObjectToPool, PoolSize, PoolSize);
	}
}
