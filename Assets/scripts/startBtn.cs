using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameStart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainScene");
    }
}
