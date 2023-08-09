using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toStartBtn : MonoBehaviour
{
    public void GoToStartScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("StartScene");
    }
}
