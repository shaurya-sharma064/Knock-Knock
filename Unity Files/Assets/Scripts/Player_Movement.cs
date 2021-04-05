using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    public int forward = 500;
    public int left = -500;
    public Rigidbody rb;

    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKey("a"))
        {
            rb.AddForce(left * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(-left * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forward * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forward * Time.deltaTime);
        }
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(0);
        }

    }

}