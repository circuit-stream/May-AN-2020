using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public void LaunchScene(int sceneNumber, int x, float y)
    {
        SceneManager.LoadScene(sceneNumber, LoadSceneMode.Single);
    }
}
