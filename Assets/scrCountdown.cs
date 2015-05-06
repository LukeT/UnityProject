using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class scrCountdown : MonoBehaviour {

	void Start () {
		StartCoroutine(loop()); 
	}

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
