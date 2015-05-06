using UnityEngine;
using System.Collections;

public class scrCamera : MonoBehaviour {

	public Transform player;
	static public bool enabled = false;

	// Update player position
	void Update () {
		if(enabled){
		transform.position = new Vector3 (player.position.x + 6, 0, -10);
		}
	}
}
