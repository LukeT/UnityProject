using UnityEngine;
using System.Collections;

/// <summary>
/// End Game Scene Events
/// </summary>
public class scrEndGame : MonoBehaviour {

	/// <summary>
	/// When the user clicks, end the game
	/// </summary>
	void OnMouseDown()
	{
		Application.Quit(); 
	}

	/// <summary>
	/// Constantly check if the user presses the escape key
	/// </summary>
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) {
				Application.Quit(); 
		}
	}
}
