using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadNextLevel ()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

}
