using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogInfo : MonoBehaviour
{
    public void DogLevels()
    {
        SceneManager.LoadScene(14);
    }

    public void backmenu()
    {
        SceneManager.LoadScene(0);
    }


}
