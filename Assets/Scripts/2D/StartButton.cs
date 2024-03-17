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
            Debug.Log("StartGame() fonksiyonu çalýþtý. " + SceneManager.GetSceneByBuildIndex(nextSceneIndex).name + " sahnesine geçiliyor.");
        }
        else
        {
            Debug.Log("Tüm sahneler yüklendi. Daha fazla sahne yok.");
        }
    }
}
