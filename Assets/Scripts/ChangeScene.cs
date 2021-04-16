using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string nextSceneName;

    public void ChangeSceneByName()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    public void ChangeSceneNextIndex()
    {
        // Changes current scene to next scene in the build settings
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

}