using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gmp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localScale *= 0.3f;
		StartCoroutine("Zap");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Zap () {
		for (int i = 0; i < 15; i++) {
			transform.localScale *= 1.1f;
			yield return null;
		}
		Destroy(gameObject);
	}
}
