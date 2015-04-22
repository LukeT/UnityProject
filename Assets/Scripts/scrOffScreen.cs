using UnityEngine;
using System.Collections;

public class scrOffScreen : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player") {
			// Player has died;
			return;
		}
	}

}
