using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

/// <summary>
/// Display countdown before the game starts
/// </summary>
public class scrCountdown : MonoBehaviour {

	/// <summary>
	/// Start the loop
	/// </summary>
	void Start () {
		StartCoroutine(loop()); 
	}

	/// <summary>
	/// Loop through an array showing different messages
	/// </summary>
	IEnumerator loop()
	{
		string[] array = {"Tap To Jump..", "3..", "2..", "1..", ""};
		
		TextMesh textObject = GameObject.Find("countdown").GetComponent<TextMesh>();
		
		foreach(string item in array)
		{
			textObject.text = item;
			yield return new WaitForSeconds(1);
		}

		scrCamera.enabled = true;
		Platformer2DUserControl.enabled = true;
	}
}
