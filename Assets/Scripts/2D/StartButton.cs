using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    public void StartGame()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
            Debug.Log("StartGame() fonksiyonu �al��t�. " + SceneManager.GetSceneByBuildIndex(nextSceneIndex).name + " sahnesine ge�iliyor.");
        }
        else
        {
            Debug.Log("T�m sahneler y�klendi. Daha fazla sahne yok.");
        }
    }
}
