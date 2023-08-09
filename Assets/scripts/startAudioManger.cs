using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startAudioManger : MonoBehaviour
{
    public AudioClip title;
    public AudioSource audioSource; 

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = title;
        audioSource.Play(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
