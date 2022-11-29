using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;
    private GameManager gm;

   
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(0, jumpForce, 0);

        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0, -.2f, 0), Quaternion.Euler(90, 0, 0));
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
       

        if (materialName == "PlatformSafe (Instance)" )
        {
            //continue
        }
        else if (materialName == "PlatformDanger (Instance)")
        {
            gm.RestartGame();
        }
        else if (materialName == "LastRing (Instance)")
        {
            //next level
            //scoring
            gm.RestartGame();
        }
    }
}
