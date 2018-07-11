using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitzGuyController : MonoBehaviour
{
	
	public float pitzGuySpeed;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (Input.GetKey (KeyCode.A))
		{
			Vector3 newDirection = new Vector3 (-pitzGuySpeed * Time.deltaTime, 0, 0);
			transform.position += newDirection;
		}
		
		if (Input.GetKey (KeyCode.D))
		{
			Vector3 newDirection = new Vector3 (pitzGuySpeed * Time.deltaTime, 0, 0);
			transform.position += newDirection;
		}
		
		if (Input.GetKey (KeyCode.W))
		{
			Vector3 newDirection = new Vector3 (0, pitzGuySpeed * Time.deltaTime, 0);
			transform.position += newDirection;
		}
		
		if (Input.GetKey (KeyCode.S))
		{
			Vector3 newDirection = new Vector3 (0, -pitzGuySpeed * Time.deltaTime, 0);
			transform.position += newDirection;
		}
	}
}