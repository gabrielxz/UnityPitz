using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour {

	private PitzGuyController rb2d;

	private Transform pitTransform;

	void Start () {
		rb2d = GameObject.FindObjectOfType<PitzGuyController> ();
		pitTransform = GetComponent<Transform> ();
	}

	void OnTriggerEnter2D (Collider2D other) {
		rb2d.Die();
		rb2d.Shrink(pitTransform.position);
	}

}