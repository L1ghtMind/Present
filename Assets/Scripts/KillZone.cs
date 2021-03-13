using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    // Start is called before the first frame update
    public float Damage = 100f;

    void OnTriggerStay2D(Collider2D other)
    {
        //If not player then exit
        if (other.transform.tag=="Player")
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }
}