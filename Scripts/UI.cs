using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip basla;
    public GameObject Name;
    public GameObject top;
    public GameObject sessiz;
    public AudioClip dusdu;
    public GameObject ses;
    public static bool ses1;
    public GameObject storepanel;
    public AudioClip bas;

    void Start()
    {
       
            ses1 = true;
        audioSource = GetComponent<AudioSource>();
    }

    public void oyun_basla()
    {
        if (Name.activeInHierarchy)
        {
            Name.SetActive(false);
            if (UI.ses1 == true)
            { audioSource.PlayOneShot(basla); }

            top.GetComponent<TopHareketi>().enabled = true;
        }

    }

    public void storeac()
    {
        storepanel.SetActive(true);
        if (UI.ses1 == true) { audioSource.PlayOneShot(bas); }

    }
 
  
    public void ses_kapat()
    {
        ses1 = false;
        ses.SetActive(false);
        sessiz.SetActive(true);
        PlayerPrefs.SetInt("ses",1);
    
    
    }

    public void ses_ac()
    {
        ses1 = true;
        ses.SetActive(true);
        sessiz.SetActive(false);
        PlayerPrefs.SetInt("ses", 2);



    }

    void Update()
    {


        if (PlayerPrefs.GetInt("ses") == 1)
        {
            ses1 = false;
            ses.SetActive(false);
            sessiz.SetActive(true);

        }
        if (PlayerPrefs.GetInt("ses") == 2)
        {
            ses1 = true;
            ses.SetActive(true);
            sessiz.SetActive(false);

        }



    }
}
