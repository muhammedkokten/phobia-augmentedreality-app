using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spider_info : MonoBehaviour
{
   public void SpiderLevel()
    {
        SceneManager.LoadScene(9);
    }

    public void backmenu()
    {
        SceneManager.LoadScene(0);
    }


}