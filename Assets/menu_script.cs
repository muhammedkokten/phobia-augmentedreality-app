using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_script : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene(2);
    }

    public void CreditButton()
    {
        SceneManager.LoadScene(6);
    }

    public void backtomainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
