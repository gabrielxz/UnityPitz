using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shinigami : MonoBehaviour {

	public GameObject target;
	public float speed;

	private LevelManager levelManager;
	private AudioSource audioSource;
	private Rigidbody2D rb2d;
	
	void Start ()
	{
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		rb2d = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody2D> ();
		audioSource = GameObject.FindGameObjectWithTag ("DeathAudio").GetComponent<AudioSource> ();
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		StartCoroutine (MyCoroutine ());
	}

	void FixedUpdate()
	{
		// Hunt target
		Vector3 offset;
		offset = transform.position - target.transform.position;
		transform.position -= offset.normalized * speed;
	}

	IEnumerator MyCoroutine () {
		rb2d.velocity = Vector3.zero;
		rb2d.Sleep ();
		audioSource.Play ();
		yield return new WaitForSeconds (1);
		levelManager.LoadLevel ("Lose Screen");
	}

}
