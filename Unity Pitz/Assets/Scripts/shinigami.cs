using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shinigami : MonoBehaviour {

	public GameObject target;
	public float speed;

	private PitzGuyController playerController;

	void Start () {
		playerController = GameObject.FindObjectOfType<PitzGuyController> ();
	}

	void OnTriggerEnter2D (Collider2D other) {
		playerController.Die ();
	}

	void FixedUpdate () {
		// Hunt target
		Vector3 offset;
		offset = transform.position - target.transform.position;
		transform.position -= offset.normalized * speed;
	}

}