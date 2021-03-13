using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneCharger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(1);
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            SceneManager.LoadScene(1);
        }
    }
}
