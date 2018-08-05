using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour {

	private PitzGuyController playerController;

	private Transform pitTransform;

	void Start () {
		playerController = GameObject.FindObjectOfType<PitzGuyController> ();
		pitTransform = GetComponent<Transform> ();
	}

	void OnTriggerEnter2D (Collider2D other) {
		playerController.Die();
		playerController.Shrink(pitTransform.position);
	}

}