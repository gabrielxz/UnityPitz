using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shinigami : MonoBehaviour {

	private LevelManager levelManager;
	
	void Start ()
	{
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		levelManager.LoadLevel ("Lose Screen");
	}
}
