using UnityEngine;
using System.Collections;

public class scrKillPlayer : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		
		Application.LoadLevel ("scnEndGame");
	}
}