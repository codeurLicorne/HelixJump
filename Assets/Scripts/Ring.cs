using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager gm;
   
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

   
    void Update()
    {
        if(transform.position.y + 17f >= ball.transform.position.y)
        {
            gm.IncreaseGameScore(10);
            Destroy(gameObject);
        }
    }
}
