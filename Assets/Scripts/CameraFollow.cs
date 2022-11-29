using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;
    public float lerpSpped;
   
    void Start()
    {
        offset = transform.position - ball.position;
    }

   
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, ball.position + offset, lerpSpped);
        transform.position = newPos;
    }
}
