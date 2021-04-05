using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerWall : MonoBehaviour
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
            GameObject Audio = GameObject.FindGameObjectWithTag("SoundManager");
            Transform sound = Audio.transform.Find("Question_Pop");
            AudioSource pop = sound.GetComponent<AudioSource>();
            pop.Play();
            TextMeshProUGUI txt = GameObject.FindGameObjectWithTag("MainCanvas").GetComponentInChildren<TextMeshProUGUI>();
            int index = ran.Next(Questions.QNo.Count);
            test = Questions.QNo[index];
            Questions.QNo.RemoveAt(index);
            txt.text = Questions.Question[test];
            print(Questions.QAns[test]);
            Destroy(gameObject);
        }
        
        

    }
   

}