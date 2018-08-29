using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class goal : MonoBehaviour
{
    private LevelManager levelManager;
    private GameObject player;

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == player)
        {
            levelManager.LoadNextLevel();
        }
    }

}
