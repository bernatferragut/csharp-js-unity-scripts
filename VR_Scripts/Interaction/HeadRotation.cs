//Script that captures our head rotation from the Gyroscope Info.
// **************************************************************

using UnityEngine;
using System.Collections;

public class HeadRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true; 

	}
	
	// Update is called once per frame
	void Update () {
		Quatternion att = Input.gyro.attitude;
		att = Quaternion.Euler(90f, 0f, 0f) * new Quaternion (att.x, att.y, -att.z, -att.w);
		transform.rotation = att;
	
	}
}
