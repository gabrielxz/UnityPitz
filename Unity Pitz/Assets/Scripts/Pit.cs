using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Pit : MonoBehaviour
{
    private PitzGuyController playerController;
    private GameObject player;
    private Transform pitTransform;
    private AudioClip deathSound;

    void Start()
    {
        playerController = GameObject.FindObjectOfType<PitzGuyController>();
        player = GameObject.FindGameObjectWithTag("Player");
        pitTransform = GetComponent<Transform>();
        deathSound = Resources.Load<AudioClip>("whoa3");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == player)
        {
            playerController.Die(deathSound);
            playerController.Shrink(pitTransform.position);
        }
    }

}
