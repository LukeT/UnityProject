using UnityEngine;
using System.Collections;

public class scrStartScreenHover : MonoBehaviour {

	void OnMouseOver() {
		GetComponent<Renderer> ().material.color = Color.yellow;
	}

	void OnMouseExit()
	{
		GetComponent<Renderer> ().material.color = Color.white;
	}
}