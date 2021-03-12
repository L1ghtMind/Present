using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{

    private CheckPoint chp;
    private void Start()
    {
        chp = GameObject.FindGameObjectWithTag("chp").GetComponent<CheckPoint>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            chp.lastCheckPoint = transform.position;
        }
    }
}
