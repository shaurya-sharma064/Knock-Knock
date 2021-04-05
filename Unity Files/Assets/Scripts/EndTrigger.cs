using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameObject player;

    public System.Random ran = new System.Random();
    public static int test;
    void Start()
    {
        Questions Questions = player.GetComponent<Questions>();


    }

    void OnTriggerEnter(Collider player)
    {
 
        if (player.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
            

        }



    }
    

}
