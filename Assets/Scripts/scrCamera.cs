using UnityEngine;
using System.Collections;

public class scrCamera : MonoBehaviour {

	public Transform player;

	// Update player position
	void Update () {
		transform.position = new Vector3 (player.position.x + 6, 0, -10);
	}
}
