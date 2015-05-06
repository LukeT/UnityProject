using UnityEngine;
using System.Collections;

/// <summary>
/// Start Screen Button
/// </summary>
public class scrStartGame : MonoBehaviour {

	/// <summary>
	/// When the player clicks, display the main level.
	/// </summary>
	void OnMouseDown()
	{
		Application.LoadLevel ("scnMainLevel");
	}
}
