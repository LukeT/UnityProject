using UnityEngine;
using System.Collections;

/// <summary>
/// Platform Spawning Script
/// </summary>
public class scrSpawnPlatform : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 1f;

	/// <summary>
	/// Spawn new platforms at a random interval
	/// </summary>
	void Start () {
		Instantiate(obj[Random.Range(0,obj.GetLength(0))], new Vector3 (transform.position.x, transform.position.y, -1), Quaternion.identity);
		Invoke ("Start", Random.Range (spawnMin, spawnMax));
	}
}
