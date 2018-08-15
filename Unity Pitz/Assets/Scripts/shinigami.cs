using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class shinigami : MonoBehaviour
{
    public float speed;

    private GameObject target;
    private AudioClip deathSound;
    private PitzGuyController playerController;

    void Start()
    {
        playerController = GameObject.FindObjectOfType<PitzGuyController>();
        target = GameObject.FindGameObjectWithTag("Player");
        deathSound = Resources.Load<AudioClip>("death1");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        playerController.Die(deathSound);
        playerController.Shrink(target.transform.position);
    }

    void FixedUpdate()
    {
        // Hunt target
        Vector3 offset;
        offset = transform.position - target.transform.position;
        transform.position -= offset.normalized * speed;
    }

}