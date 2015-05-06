using UnityEngine;
using System.Collections;

public class scrDisplayScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("called");
		int Score = scrUpdateCounter.getScore ();

		TextMesh textObject = GameObject.Find("score").GetComponent<TextMesh>();
		textObject.text = "Score: "  + Score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
