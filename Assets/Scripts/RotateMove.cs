using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour
{
    public float rotateSpeed;
    private float moveX;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0))
        {
            //rotate cylinder
            transform.Rotate(0, rotateSpeed * moveX * Time.deltaTime, 0);
        }
    }
}
