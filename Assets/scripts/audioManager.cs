using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip inGame;
    public AudioSource audioSource; 

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = inGame;
        audioSource.Play(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
