// Script to change the color of an object
// ***************************************

using UnityEngine;
using System.Collections;

public class clickColor : MonoBehaviour {

	// variables
	Color originalColor;
	public Color color = Color.red;

	// functions
	void Start () {
		originalColor = renderer.material.color;
	}

	void OnMouseDown () {

		if (renderer.material.color == originalColor){
			renderer.material.color == color;
		} else {
			renderer.material.color = originalColor;
		}
	}

// *********************************************