using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_choise_script : MonoBehaviour
{
    public void DogButton()
    {
        SceneManager.LoadScene(13);
    }

    public void SpiderButton()
    {
        SceneManager.LoadScene(10);
    }

    public void SocialButton()
    {
        SceneManager.LoadScene(5);
    }

    public void backmainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
