using UnityEngine;
using System.Collections;

public class gaze_highlighter : MonoBehaviour {

	public OVRCameraRig			cameraController = null;
	public GameObject[]                     MySampleCubes;

	void Awake()
	{
		if (cameraController == null) {
			Debug.LogError ("ERROR: Missing camera controller reference on " + name);
			enabled = false;
			return;
		}

		// Initially let us disable rendering of text on all the cubes. 
		for (int i = 0; i < MySampleCubes.Length; i++) {

			Renderer[] r = MySampleCubes[i].GetComponentsInChildren<Renderer>();
			r[1].enabled = false ;

		}

	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// handle user gaze
		Ray ray = new Ray(cameraController.centerEyeAnchor.position, cameraController.centerEyeAnchor.forward);
		RaycastHit hit = new RaycastHit();

		// Check if the ray is hitting the colliders in everty frame 
		for (int i = 0; i < MySampleCubes.Length; i++) {
		    // If ray hits the collider then enable rendering of text 
			if(MySampleCubes[i].GetComponent<Collider>().Raycast (ray, out hit, 100.0f)){
				Renderer[] r = MySampleCubes[i].GetComponentsInChildren<Renderer>();
				r[1].enabled = true ;
			}
			// If ray does not hit the collider the ndisable rendering of text. 
			else
			{
				Renderer[] r = MySampleCubes[i].GetComponentsInChildren<Renderer>();
				r[1].enabled = false ;
			}
		}	
	}
}
