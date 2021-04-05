using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelector : MonoBehaviour
{

    public static int WallNos;
    public void PlayGame5()
    {
     WallNos=5;
     print(WallNos);
     SceneManager.LoadScene(4);
     ScoreScript.scoreValue = 0;
    }
    public void PlayGame10()
    {
        WallNos = 10;
        print(WallNos);
        SceneManager.LoadScene(4);
        ScoreScript.scoreValue = 0;
    }
    public void PlayGame15()
    {
        WallNos = 15;
        print(WallNos);
        SceneManager.LoadScene(4);
        ScoreScript.scoreValue = 0;
    }
    public void PlayGame20()
    {
        WallNos = 20;
        print(WallNos);
        SceneManager.LoadScene(4);
        ScoreScript.scoreValue = 0;
    }


}
