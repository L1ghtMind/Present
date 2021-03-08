using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateMoveHorizontaly : MonoBehaviour
{
    private Vector3 OriginPos = Vector3.zero;
    public Vector3 MoveAxes = Vector3.zero;
    public float Distance = 3f;

    void Start()
    {
        OriginPos = transform.position;
    }

    void Update()
    {
        transform.position = OriginPos + MoveAxes * Mathf.PingPong(Time.time, Distance);
    }
}

