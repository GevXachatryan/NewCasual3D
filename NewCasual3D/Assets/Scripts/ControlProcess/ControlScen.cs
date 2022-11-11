using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScen : MonoBehaviour
{
    // Код привязан на Canvas





    public void KeepPlaying()  // Отвечает за переход между сценами
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lvCount"));
    }

    public void StartOver()
    {
        SceneManager.LoadScene(1);
    }

    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();
    }
       public void LoadManu()
    {
        SceneManager.LoadScene(0);
    }
}
