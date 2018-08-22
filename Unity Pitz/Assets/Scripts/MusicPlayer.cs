using System.Collections;

using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;

    AudioSource backgroundAudioSource;

    void Start()
    {

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);

            backgroundAudioSource = GetComponent<AudioSource>();
            backgroundAudioSource.clip = Resources.Load<AudioClip>("horrorAmbience");
            backgroundAudioSource.Play();
        }

    }
}