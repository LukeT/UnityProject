using UnityEngine;
using System.Collections;

/// <summary>
/// Score Counting Class for collisions
/// </summary>
public class scrScoreCollision : MonoBehaviour {

	private bool enabled = true;
	private int lastScore;

	/// <summary>
	/// When the player collides, increment the score
	/// </summary>
	/// <param name="coll">Coll.</param>
	void OnCollisionEnter2D(Collision2D coll) {
		if (enabled) {
			scrUpdateCounter.incrementScore ();
			enabled = false;
			lastScore = scrUpdateCounter.getScore();
			Invoke("checkScore", 4);
		}
	}

	/// <summary>
	/// Check if the player has not moved in four seconds, if they haven't kill the player.
	/// </summary>
	void checkScore()
	{
		if (lastScore == scrUpdateCounter.getScore ()) {
			Application.LoadLevel ("scnEndGame");
		}

	}

}
