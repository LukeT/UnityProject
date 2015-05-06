using UnityEngine;
using System.Collections;

/// <summary>
/// Camera Movement Script
/// </summary>
public class scrCamera : MonoBehaviour {
	
	public Transform player;
	static public bool enabled = false;

	/// <summary>
	/// Move the camera to give the effect of a never ending level
	/// </summary>
	void Update () {
		if(enabled){
			transform.position = new Vector3 (player.position.x + 6, 0, -10);
		}
	}
}
