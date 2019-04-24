using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour {

    public string sceneName;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene("lake");
            SceneManager.UnloadSceneAsync(sceneName);
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("castle");
            SceneManager.UnloadSceneAsync(sceneName);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("spaceEnvo");
            SceneManager.UnloadSceneAsync(sceneName);
        }
    }
}
