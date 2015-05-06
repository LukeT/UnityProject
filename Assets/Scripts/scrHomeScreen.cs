using UnityEngine;
using System.Collections;

/// <summary>
/// Home Screen Buttons 
/// </summary>
public class scrHomeScreen : MonoBehaviour {

	/// <summary>
	/// When the user clicks, show the Welcome scene.
	/// </summary>
	void OnMouseDown()
	{
		Application.LoadLevel ("scnWelcome");

	}
}
