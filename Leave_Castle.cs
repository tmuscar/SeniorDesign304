using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leave_Castle : MonoBehaviour {

   /* public void SelectScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
        SceneManager.UnloadSceneAsync("castle");
    }*/

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Main_Menu");
            SceneManager.UnloadSceneAsync("castle");
        }
    }
}
