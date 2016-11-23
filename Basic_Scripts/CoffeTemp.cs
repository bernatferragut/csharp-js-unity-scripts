using UnityEngine;
using System.Collections;

public class CoffeTemp : MonoBehaviour {

	public float coffeeTempStart = 90f;
	public float coffeTempMax = 40f;
	public float coffeTempMin = 20f;

	// Use this for initialization
	void Start () 
	{
		// Nothing to declare
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			CheckTemperature ();
		}

		coffeeTempStart -= Time.deltaTime * 5f;
	}

	void CheckTemperature ()
	{
		if (coffeeTempStart > coffeTempMax) 
		{
			Debug.Log(" TOO HOT!");
		}
		else if (coffeeTempStart < coffeTempMin) 
		{
			Debug.Log(" TOO COLD");
		}
		else 
		{
			Debug.Log(" JUST RIGHT!");
		}
	}
}
