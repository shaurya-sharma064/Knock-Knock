using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCreator : MonoBehaviour
{
    int WallNos = StageSelector.WallNos;
    public GameObject WallsAndTrigger;
    public GameObject Finish;

    void Start()
    {
        int k = 2;
        for (k = 2; k < WallNos+1; k++)
        {
            Instantiate(WallsAndTrigger, new Vector3(2.002823f ,- 3.093146F,k * 24.22034f), Quaternion.identity);
        }
        float a = k * 24.22034f - 10;
        Instantiate(Finish, new Vector3(0f, 0F, a), Quaternion.identity);
    }

    
}
