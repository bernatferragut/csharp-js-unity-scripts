// To Get an Object through the Main Camera

using UnityEngine;
using System.Collections;

public class Agarre : MonoBehaviour
{
	private Vector3 startingPosition;
	public GvrHead GV;
	Transform Head; 
	bool secondClick;
	Rigidbody RB;

	[Range ( 1, 50)]
	public float speed;

	void Start()
	{
		startingPosition = transform.localPosition;
		this.GetComponent<Renderer> ().material.color = Color.black;
		Head = GV.transform.GetChild (0);
		RB = GetComponent <Rigidbody>();
	
	}

	//Agarrar
	public void GetObject()
	{
		if (secondClick == false) 
		{
			transform.parent = Head;
			secondClick = true;
		}
		else 
		{
			transform.parent = null;
			secondClick = false;
			RB.velocity = Head.forward * speed;
		}
	}
		
	// Color Changes
	public void onEnter()
	{
		this.GetComponent<Renderer> ().material.color = Color.red;
	}

	public void onExit()
	{
		this.GetComponent<Renderer> ().material.color = Color.black;
	}
}