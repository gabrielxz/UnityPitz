using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shinigami : MonoBehaviour {

	public GameObject target;
	public float speed;

	private LevelManager levelManager;
	
	void Start ()
	{
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		levelManager.LoadLevel ("Lose Screen");
	}

	void FixedUpdate()
	{
		// Hunt target
		Vector3 offset;
		offset = transform.position - target.transform.position;
		transform.position -= offset.normalized * speed;
	}
}
