using UnityEngine;
using System.Collections;

/// <summary>
/// Kill Player Class
/// </summary>
public class scrKillPlayer : MonoBehaviour {

	/// <summary>
	/// When the layer collides with the object, show the end game scene
	/// </summary>
	/// <param name="coll">Coll.</param>
	void OnCollisionEnter2D(Collision2D coll) {
		
		Application.LoadLevel ("scnEndGame");
	}
}