using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Select : MonoBehaviour {



    public void buttonSelect(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        SceneManager.UnloadSceneAsync("Main_Menu");
    }
}
