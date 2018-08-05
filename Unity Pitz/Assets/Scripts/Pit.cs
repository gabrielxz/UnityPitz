using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour {

	private LevelManager levelManager;

	private AudioSource audioSource;

	private Rigidbody2D rb2d;

	void Start () {
		rb2d = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody2D> ();
		audioSource = GameObject.FindGameObjectWithTag ("DeathAudio").GetComponent<AudioSource> ();
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}

	void OnTriggerEnter2D (Collider2D other) {
		StartCoroutine (MyCoroutine ());
	}

	IEnumerator MyCoroutine () {
		rb2d.velocity = Vector3.zero;
		rb2d.Sleep ();
		audioSource.Play ();
		yield return new WaitForSeconds (1);
		levelManager.LoadLevel ("Lose Screen");
	}

}