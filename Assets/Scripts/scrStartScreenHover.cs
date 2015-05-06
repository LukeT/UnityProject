using UnityEngine;
using System.Collections;

/// <summary>
/// Start screen button hover
/// </summary>
public class scrStartScreenHover : MonoBehaviour {

	/// <summary>
	/// Whe  the user hovers, change the colour to yellow
	/// </summary>
	void OnMouseOver() {
		GetComponent<Renderer> ().material.color = Color.yellow;
	}

	/// <summary>
	/// When the mouse leaves, change back to white.
	/// </summary>
	void OnMouseExit()
	{
		GetComponent<Renderer> ().material.color = Color.white;
	}
}