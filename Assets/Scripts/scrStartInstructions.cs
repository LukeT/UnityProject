using UnityEngine;
using System.Collections;

/// <summary>
/// Instruction Screens Button
/// </summary>
public class scrStartInstructions : MonoBehaviour {

	/// <summary>
	/// When the player clicks, display the instructions screen
	/// </summary>
	void OnMouseDown()
	{
		Application.LoadLevel ("scnInstructions");
	}
}
