using UnityEngine;
using System.Collections;

public class Singleton : MonoBehaviour {

	private int _currentScore;
	// Here we declare the one and only instance possible called the singleton
	public static MainGameManager instance;

	void Awake()
	{	
		instance.this; // Here we create the one and only instance possible called the singleton
	}


	public adjustScore( int num)
	{
		_currentScore = _currentScore + num;
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 100, 100, 100), "Score = " + _currentScore);
	}

}
