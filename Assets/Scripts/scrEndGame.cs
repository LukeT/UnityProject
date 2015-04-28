using UnityEngine;
using System.Collections;

public class scrEndGame : MonoBehaviour {

	void OnMouseDown()
	{
		Application.Quit(); 
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) {
				Application.Quit(); 
		}
	}
}
