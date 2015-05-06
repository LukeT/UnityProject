using UnityEngine;
using System.Collections;

/// <summary>
/// Display the score on the end screen
/// </summary>
public class scrDisplayScore : MonoBehaviour {

	/// <summary>
	/// Output the score to the end screen
	/// </summary>
	void Start () {
		int Score = scrUpdateCounter.getScore ();

		TextMesh textObject = GameObject.Find("score").GetComponent<TextMesh>();
		textObject.text = "Score: "  + Score.ToString ();
	}

}
