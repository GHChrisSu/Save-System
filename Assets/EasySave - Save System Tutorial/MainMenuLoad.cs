using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoad : MonoBehaviour {
    public string levelToLoad;

    public void Load()
    {
        levelToLoad = ES2.Load<string>("savedScene");
        SceneManager.LoadScene(levelToLoad);
    }
	
}
