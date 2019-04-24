using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leave_Lake : MonoBehaviour
{


    public void SelectScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
        SceneManager.UnloadSceneAsync("test_terraini");
    }
}
