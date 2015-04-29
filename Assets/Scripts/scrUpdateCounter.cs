using UnityEngine;
using System.Collections;

public class scrUpdateCounter : MonoBehaviour {

	static public int score = 0;

	// Use this for initialization
	void Start () {	
		TextMesh textObject = GameObject.Find("score").GetComponent<TextMesh>();
		textObject.text = score.ToString();
	}

	public static void incrementScore()
	{
		score++;
		TextMesh textObject = GameObject.Find("score").GetComponent<TextMesh>();
		textObject.text = score.ToString();
	}

	public static int getScore()
	{
		return score;
	}

	public static void resetScore()
	{
		score = 0;
		TextMesh textObject = GameObject.Find("score").GetComponent<TextMesh>();
		textObject.text = score.ToString();
	}
}
