using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogLevel : MonoBehaviour
{
public void DogEasy()
    {
        SceneManager.LoadScene(4);
    }

    public void DogMedium()
    {
        SceneManager.LoadScene(11);
    }

    public void DogHard()
    {
        SceneManager.LoadScene(12);
    }

    public void backmainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
