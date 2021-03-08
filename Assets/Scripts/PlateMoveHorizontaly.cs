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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.collider.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.collider.transform.SetParent(null);
        }
    }
    void Update()
    {
        transform.position = OriginPos + MoveAxes * Mathf.PingPong(Time.time, Distance);
    }
}

