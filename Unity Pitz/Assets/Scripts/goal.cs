using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{

    private LevelManager levelManager;

    private ParticleSystem pSystem;

    private PitzGuyController playerController;

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        pSystem = GameObject.FindGameObjectWithTag ("WinParticles").GetComponent<ParticleSystem> ();
        playerController = GameObject.FindObjectOfType<PitzGuyController> ();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine (WinCourotine ());
    }

    
    IEnumerator WinCourotine () {
            playerController.Freeze();
            pSystem.Play();
            yield return new WaitForSeconds (3f);
            levelManager.LoadNextLevel();
    }

}
