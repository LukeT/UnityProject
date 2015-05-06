using UnityEngine;
using System.Collections;

/// <summary>
/// Score Script
/// </summary>
public class scrUpdateCounter : MonoBehaviour {

	static public int score = 0;

	/// <summary>
	/// When the script starts, display the score on screen
	/// </summary>
	void Start () {	
		TextMesh textObject = GameObject.Find("score").GetComponent<TextMesh>();
		textObject.text = score.ToString();
	}

	/// <summary>
	/// Increment the score, and update the on screen display
	/// </summary>
	public static void incrementScore()
	{
		score++;
		TextMesh textObject = GameObject.Find("score").GetComponent<TextMesh>();
		textObject.text = score.ToString();
	}

	/// <summary>
	/// Return the score
	/// </summary>
	/// <returns>The score.</returns>
	public static int getScore()
	{
		return score;
	}

	/// <summary>
	/// Reset the score to 0
	/// </summary>
	public static void resetScore()
	{
		score = 0;
		TextMesh textObject = GameObject.Find("score").GetComponent<TextMesh>();
		textObject.text = score.ToString();
	}
}
