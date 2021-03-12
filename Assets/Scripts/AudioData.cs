using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioData : MonoBehaviour
{
    AudioSource audioSource;
    Scene scene;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        scene = SceneManager.GetActiveScene();
        if (scene.name == "SampleScene")
        {
            audioSource.Play();
        }
    }

    
}
