using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endingCreaditHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;

    private void Awake()
    {
    }
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnterNextScene()
    {
        SceneManager.LoadScene("StartScene"); 
    }
}
