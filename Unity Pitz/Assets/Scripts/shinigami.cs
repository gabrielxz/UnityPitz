using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class shinigami : MonoBehaviour
{
    private float hunt = 0.05f;
    private float bounce = -0.55f;

    private GameObject target;
    private AudioClip deathSound;
    private PitzGuyController playerController;

    void Start()
    {
        playerController = GameObject.FindObjectOfType<PitzGuyController>();
        target = GameObject.FindGameObjectWithTag("Player");
        deathSound = Resources.Load<AudioClip>("death1");
    }

    void TrackTarget(float speed)
    {
        Vector3 offset;
        offset = transform.position - target.transform.position;
        transform.position -= offset.normalized * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == target)
        {
            playerController.Die(deathSound);
            playerController.Shrink(target.transform.position);
        }
        else if(other.gameObject.tag == "GMP")
        {
            TrackTarget(bounce);
        }
    }

    void FixedUpdate()
    {
        TrackTarget(hunt);
    }
}
