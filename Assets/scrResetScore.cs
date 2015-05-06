using UnityEngine;
using System.Collections;

/// <summary>
/// Reset the score
/// </summary>
public class scrResetScore : MonoBehaviour {

	/// <summary>
	/// Reset the score.
	/// </summary>
	void Start () {
		scrUpdateCounter.resetScore();
	}
}
