using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toEnding : MonoBehaviour
{
    public void GoToEndingScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("EndingScene");
    }
}
