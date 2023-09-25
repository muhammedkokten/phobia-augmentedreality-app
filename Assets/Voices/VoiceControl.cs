using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceControl : MonoBehaviour
{
    public AudioSource playvoice;
    public AudioClip[] voice;
    public GameObject[] activity;

    public void choise1()
    {
        playvoice.PlayOneShot(voice[0], .7f);
        activity[0].SetActive(true);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
        
        
    }

    public void choise2()
    {
        playvoice.PlayOneShot(voice[1], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(true);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise3()
    {
        playvoice.PlayOneShot(voice[2], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(true);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }

    public void choise4()
    {
        playvoice.PlayOneShot(voice[3], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(true);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise5()
    {
        playvoice.PlayOneShot(voice[4], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(true);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise6()
    {
        playvoice.PlayOneShot(voice[5], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(true);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise7()
    {
        playvoice.PlayOneShot(voice[6], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(true);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise8()
    {
        playvoice.PlayOneShot(voice[7], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(true);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise9()
    {
        playvoice.PlayOneShot(voice[8], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(true);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise10()
    {
        playvoice.PlayOneShot(voice[9], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(true);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise11()
    {
        playvoice.PlayOneShot(voice[10], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(true);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise12()
    {
        playvoice.PlayOneShot(voice[11], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(true);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise13()
    {
        playvoice.PlayOneShot(voice[12], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(true);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise14()
    {
        playvoice.PlayOneShot(voice[13], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(true);
        activity[14].SetActive(false);
        activity[15].SetActive(false);
    }


    public void choise15()
    {
        playvoice.PlayOneShot(voice[14], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(true);
        activity[15].SetActive(false);
    }

    public void choise16()
    {
        playvoice.PlayOneShot(voice[15], .7f);
        activity[0].SetActive(false);
        activity[1].SetActive(false);
        activity[2].SetActive(false);
        activity[3].SetActive(false);
        activity[4].SetActive(false);
        activity[5].SetActive(false);
        activity[6].SetActive(false);
        activity[7].SetActive(false);
        activity[8].SetActive(false);
        activity[9].SetActive(false);
        activity[10].SetActive(false);
        activity[11].SetActive(false);
        activity[12].SetActive(false);
        activity[13].SetActive(false);
        activity[14].SetActive(false);
        activity[15].SetActive(true);
    }

   
}
