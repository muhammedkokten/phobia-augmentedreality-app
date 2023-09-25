using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spider_level : MonoBehaviour
{
  public void SpiderEasy()
    {
        SceneManager.LoadScene(3);
    }

    public void SpiderMedium()
    {
        SceneManager.LoadScene(7);
    }

    public void SpiderHard()
    {
        SceneManager.LoadScene(8);
    }

    public void backmainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
