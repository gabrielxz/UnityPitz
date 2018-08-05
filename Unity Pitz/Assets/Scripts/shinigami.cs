using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shinigami : MonoBehaviour {

	public GameObject target;
	public float speed;

	private PitzGuyController rb2d;

	void Start () {
		rb2d = GameObject.FindObjectOfType<PitzGuyController> ();
	}

	void OnTriggerEnter2D (Collider2D other) {
		rb2d.Die ();
	}

	void FixedUpdate () {
		// Hunt target
		Vector3 offset;
		offset = transform.position - target.transform.position;
		transform.position -= offset.normalized * speed;
	}

}