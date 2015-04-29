using UnityEngine;
using System.Collections;

public class scrScoreCollision : MonoBehaviour {

	private bool enabled = true;
	private int lastScore;

	void OnCollisionEnter2D(Collision2D coll) {
		if (enabled) {
			scrUpdateCounter.incrementScore ();
			enabled = false;
			lastScore = scrUpdateCounter.getScore();
			Invoke("checkScore", 4);
		}
	}

	void checkScore()
	{
		if (lastScore == scrUpdateCounter.getScore ()) {
			Application.LoadLevel ("scnEndGame");
		}

	}

}
