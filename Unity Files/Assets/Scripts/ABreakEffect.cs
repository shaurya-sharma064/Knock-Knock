using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABreakEffect : MonoBehaviour
{

    public GameObject broken;
    public GameObject player;
    public GameObject triggerwall;
    public static int change = 0;
    public System.Random ran = new System.Random();
    void Start()
    {
        
        Questions Questions = player.GetComponent<Questions>();
        TriggerWall TriggerWall = triggerwall.GetComponent<TriggerWall>();
    }


    void OnCollisionEnter(Collision col)
    {
        
        string check = gameObject.name;
        if (col.gameObject.tag == "Player" && Questions.QAns[TriggerWall.test] == check.Substring(0, 1))
        {
            ScoreScript.scoreValue += 100;
            GameObject fractured=Instantiate(broken, transform.position, Quaternion.Euler(90f, 90f, 0f));
            Destroy(gameObject);
            Rigidbody[] particles = fractured.GetComponentsInChildren<Rigidbody>();
            if(particles.Length > 0)
            {
                foreach(var body in particles)
                {
                    body.AddExplosionForce(500, transform.position, 2);
                    body.mass = 0.001f;
                }
            }
            
            GameObject Audio = GameObject.FindGameObjectWithTag("SoundManager");
            if (change==0)
            {
                Transform sound = Audio.transform.Find("Right");
                AudioSource Right = sound.GetComponent<AudioSource>();
                Right.Play();
                change = 1;
            }
            else if(change==1)
            {
                Transform sound = Audio.transform.Find("Noice");
                AudioSource Noice = sound.GetComponent<AudioSource>();
                Noice.Play();
                change = 0;
            }

        }
        else if(col.gameObject.tag == "Player")
        {

            ScoreScript.scoreValue -= 50;
            GameObject Audio = GameObject.FindGameObjectWithTag("SoundManager");
           while(true)
            {
                if (change == 0)
                {
                    Transform sound = Audio.transform.Find("wrong");
                    AudioSource wrong = sound.GetComponent<AudioSource>();
                    wrong.Play();
                    change = 1;
                    break;
                }
                else
                {
                    Transform sound = Audio.transform.Find("Error");
                    AudioSource Error = sound.GetComponent<AudioSource>();
                    Error.Play();
                    change = 0;
                    break;
                }
            }
            
            
        }
        
     
        }
 
}
    
