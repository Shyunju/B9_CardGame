using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingAudioManager : MonoBehaviour
{
    public AudioClip endingBgm;
    public AudioSource audioSource; 
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = endingBgm;
        audioSource.Play(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
