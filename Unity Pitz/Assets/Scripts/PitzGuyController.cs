using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PitzGuyController : MonoBehaviour
{

    public float speed;

    private Rigidbody2D playerRigidbody;

    private AudioSource deathAudio;

    private LevelManager levelManager;

    private Transform playerTransform;

    private bool isFrozen = false;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerRigidbody.freezeRotation = true;
        deathAudio = GameObject.FindGameObjectWithTag("DeathAudio").GetComponent<AudioSource>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        playerTransform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        if (movement.sqrMagnitude > 1)
        {
            movement = movement.normalized;
        }

        if (movement.magnitude > 0 && !isFrozen)
        {
            playerRigidbody.AddForce(movement * speed);
        }
        else
        {
            playerRigidbody.AddForce(new Vector2(-playerRigidbody.velocity.normalized.x, -playerRigidbody.velocity.normalized.y) * 6);
        }
    }

    public void Die(AudioClip deathSound)
    {
        StartCoroutine(DeathCourotine(deathSound));

    }

    public void Shrink(Vector3 pos)
    {
        StartCoroutine(ShrinkCourotine(pos));
    }

    IEnumerator DeathCourotine(AudioClip deathSound)
    {
        playerRigidbody.velocity = Vector3.zero;
        isFrozen = true;
        deathAudio.clip = deathSound;
        deathAudio.Play();
        yield return new WaitForSeconds(2);
        levelManager.LoadLevel("Lose Screen");
    }

    IEnumerator ShrinkCourotine(Vector3 pos)
    {
        for (int i = 0; i < 10; i++)
        {
            playerTransform.position = pos;
            Vector3 currentScale = playerTransform.localScale;
            playerTransform.localScale = new Vector3(currentScale.x - 0.1f, currentScale.y - 0.1f, currentScale.z - 0.1f);
            yield return new WaitForSeconds(0.1f);
        }
    }
}