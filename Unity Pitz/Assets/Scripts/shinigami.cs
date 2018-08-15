using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shinigami : MonoBehaviour {

	private GameObject target;
	public float speed;
	private AudioClip deathSound;
	private bool isFrozen = false;

	private PitzGuyController playerController;

	void Start () {
		playerController = GameObject.FindObjectOfType<PitzGuyController> ();
		target = GameObject.FindGameObjectWithTag ("Player");
		deathSound = Resources.Load<AudioClip> ("death1");
	}

	void OnTriggerEnter2D (Collider2D other) {
		Freeze();
		playerController.Die (deathSound);
		playerController.Shrink (target.transform.position);
	}

	
    public void Freeze(){
        isFrozen = true;
    }

	void FixedUpdate () {
		if(!isFrozen){
			Vector3 offset;
			offset = transform.position - target.transform.position;
			transform.position -= offset.normalized * speed;
		}
	}

}