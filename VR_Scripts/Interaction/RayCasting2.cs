using UnityEngine;
using System.Collections;

public class RayCasting2 : MonoBehaviour {

	// Initialize varaibles

	public string objectCollided;
	public TextMesh textMessage;

	void Start () 
	{
		textMessage = GameObject.Find("TextPanel").GetComponent<TextMesh> ();
		textMessage.text = "nothing";
	}

	// We RayCast

	public void FixedUpdate() 
	{
		RaycastHit hit; // the one who stores hit info - very important !!!
		Vector3 origin = transform.position;
		Vector3 direction = transform.TransformDirection(Vector3.forward);
		Ray myRay = new Ray (origin, direction);

		//If we collide we announce the object collided to the Console and to a 3DText

		if (Physics.Raycast (myRay, out hit, 100f)) 
		{
			objectCollided = hit.collider.gameObject.name;

			print (objectCollided); // == Debug.Log in Console

			textMessage.text = objectCollided; // printing to the 3D Text.TextMesh.text
		} 
		else 
		{
			textMessage.text = "nothing"; // printing to the 3D Text.TextMesh.text
		}
	}
		
}

