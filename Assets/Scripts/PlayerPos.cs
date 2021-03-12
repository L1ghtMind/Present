using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    private CheckPoint chp;
    void Start()
    {
        chp = GameObject.FindGameObjectWithTag("chp").GetComponent<CheckPoint>();
        transform.position = chp.lastCheckPoint;
    }
}
