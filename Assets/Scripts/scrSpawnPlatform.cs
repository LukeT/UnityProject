using UnityEngine;
using System.Collections;

public class scrSpawnPlatform : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 1f;

	// Use this for initialization
	void Start () {
		spawnItem ();
	}
	
	void spawnItem()
	{
		Instantiate(obj[Random.Range(0,obj.GetLength(0))], new Vector3 (transform.position.x, transform.position.y, -1), Quaternion.identity);
		Invoke ("spawnItem", Random.Range (spawnMin, spawnMax));
	}

}
