using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class goal : MonoBehaviour
{

    private LevelManager levelManager;

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        levelManager.LoadNextLevel();
    }

}