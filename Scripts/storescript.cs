using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class storescript: MonoBehaviour
{

    public GameObject top;
     public GameObject kilit_gri;
    public GameObject kilit_k�rm�z�;
    public GameObject kilit_mor;
    public GameObject kilit_lacivert;
    public GameObject kilit_turkuaz;
    public GameObject kilit_ye�il;
    public GameObject kilit_sar�;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material mat5;
    public Material mat6;
    public Material mat7;
    public Material mat8;
    public GameObject storepanel;
    public Text collected;
    public Text collecteds;
    public AudioSource audioSource;
    public AudioClip bas;

    public static int a;

    void Start()
    {

        PlayerPrefs.GetInt("siyah") ;
        PlayerPrefs.GetInt("gri");
        PlayerPrefs.GetInt("k�rm�z�");
        PlayerPrefs.GetInt("mor");
        PlayerPrefs.GetInt("lacivert");
        PlayerPrefs.GetInt("turkuaz");
        PlayerPrefs.GetInt("ye�il");
        PlayerPrefs.GetInt("sar�");
        PlayerPrefs.GetInt("secilitop");
        audioSource = GetComponent<AudioSource>();

    }

    public void storekapat()
    {
        
        if (PlayerPrefs.GetInt("secilitop") == 1) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat1); }
        if (PlayerPrefs.GetInt("secilitop") == 2) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat2); }
        if (PlayerPrefs.GetInt("secilitop") == 3) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat3); }
        if (PlayerPrefs.GetInt("secilitop") == 4) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat4); }
        if (PlayerPrefs.GetInt("secilitop") == 5) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat5); }
        if (PlayerPrefs.GetInt("secilitop") == 6) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat6); }
        if (PlayerPrefs.GetInt("secilitop") == 7) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat7); }
        if (PlayerPrefs.GetInt("secilitop") == 8) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat8); }
        if (UI.ses1 == true) { audioSource.PlayOneShot(bas); }
        storepanel.SetActive(false);
    }
    public void siyahbtn()  { PlayerPrefs.SetInt("secilitop", 1);
        if (UI.ses1 == true) { audioSource.PlayOneShot(bas); }
    }
    public void gribtn()
    {

        if (kilit_gri.activeInHierarchy)
        {
            if (PlayerPrefs.GetInt("collected") >= 100)
            {
                PlayerPrefs.SetInt("gri", 1);
                kilit_gri.SetActive(false);
                PlayerPrefs.SetInt("secilitop", 2);

                a = PlayerPrefs.GetInt("collected");
                a = a - 100;
                Skor.collect = a;
                PlayerPrefs.SetInt("collected", a);
                collecteds.text = "X " + PlayerPrefs.GetInt("collected").ToString();
                collected.text = "X" + "\n" + PlayerPrefs.GetInt("collected").ToString();

            }
        }
        else { PlayerPrefs.SetInt("secilitop", 2); }
        if (UI.ses1 == true) { audioSource.PlayOneShot(bas); }

    }
    public void k�rm�z�btn()
    {
        if (UI.ses1 == true) { audioSource.PlayOneShot(bas); }
        if (kilit_k�rm�z�.activeInHierarchy)
        {
            if (PlayerPrefs.GetInt("collected") >= 100)
            {
                kilit_k�rm�z�.SetActive(false);
                PlayerPrefs.SetInt("k�rm�z�", 1);
                PlayerPrefs.SetInt("secilitop", 3);

                a = PlayerPrefs.GetInt("collected");
                a = a - 100;
                Skor.collect = a;
                PlayerPrefs.SetInt("collected", a);
                collecteds.text = "X " + PlayerPrefs.GetInt("collected").ToString();
                collected.text = "X" + "\n" + PlayerPrefs.GetInt("collected").ToString();

            }
        }
        else { PlayerPrefs.SetInt("secilitop", 3); }


    }
    public void morbtn()
    {
        if (UI.ses1 == true) { audioSource.PlayOneShot(bas); }
        if (kilit_mor.activeInHierarchy)
        {
            if (PlayerPrefs.GetInt("collected") >= 100)
            {
                kilit_mor.SetActive(false);
                PlayerPrefs.SetInt("mor", 1);
                PlayerPrefs.SetInt("secilitop", 4);

                a = PlayerPrefs.GetInt("collected");
                a = a - 100;
                Skor.collect = a;
                PlayerPrefs.SetInt("collected", a);
                collecteds.text = "X " + PlayerPrefs.GetInt("collected").ToString();
                collected.text = "X" + "\n" + PlayerPrefs.GetInt("collected").ToString();

            }
        }
        else { PlayerPrefs.SetInt("secilitop", 4); }


    }
    public void lacivertbtn()
    {
        if (UI.ses1 == true) { audioSource.PlayOneShot(bas); }
        if (kilit_lacivert.activeInHierarchy)
        {
            if (PlayerPrefs.GetInt("collected") >= 100)
            {
                kilit_lacivert.SetActive(false);
                PlayerPrefs.SetInt("lacivert", 1);
                PlayerPrefs.SetInt("secilitop", 5);

                a = PlayerPrefs.GetInt("collected");
                a = a - 100;
                Skor.collect = a;
                PlayerPrefs.SetInt("collected", a);
                collecteds.text = "X " + PlayerPrefs.GetInt("collected").ToString();
                collected.text = "X" + "\n" + PlayerPrefs.GetInt("collected").ToString();

            }
        }
        else { PlayerPrefs.SetInt("secilitop", 5); }


    }
    public void turkuazbtn()
    {
        if (UI.ses1 == true) { audioSource.PlayOneShot(bas); }

        if (kilit_turkuaz.activeInHierarchy)
        {
            if (PlayerPrefs.GetInt("collected") >= 100)
            {
                kilit_turkuaz.SetActive(false);
                PlayerPrefs.SetInt("turkuaz", 1);
                PlayerPrefs.SetInt("secilitop", 6);

                a = PlayerPrefs.GetInt("collected");
                a = a - 100;
                Skor.collect = a;

                PlayerPrefs.SetInt("collected", a);
                collecteds.text = "X " + PlayerPrefs.GetInt("collected").ToString();
                collected.text = "X" + "\n" + PlayerPrefs.GetInt("collected").ToString();

            }
        }
        else { PlayerPrefs.SetInt("secilitop", 6); }


    }
    public void yesilbtn()
    {
        if (UI.ses1 == true) { audioSource.PlayOneShot(bas); }
        if (kilit_ye�il.activeInHierarchy)
        {
            if (PlayerPrefs.GetInt("collected") >= 100)
            {
                kilit_ye�il.SetActive(false);
                PlayerPrefs.SetInt("ye�il", 1);
                PlayerPrefs.SetInt("ye�il", 1);
                PlayerPrefs.SetInt("secilitop", 7);

                a = PlayerPrefs.GetInt("collected");
                a = a - 100;
                Skor.collect = a;
                PlayerPrefs.SetInt("collected", a);
                collecteds.text = "X " + PlayerPrefs.GetInt("collected").ToString();
                collected.text = "X" + "\n" + PlayerPrefs.GetInt("collected").ToString();


            }
        }
        else { PlayerPrefs.SetInt("secilitop", 7); }


    }

    public void saribtn()
    {
        if (UI.ses1 == true) { audioSource.PlayOneShot(bas); }

        if (kilit_sar�.activeInHierarchy)
        {
            if (PlayerPrefs.GetInt("collected") >= 100)
            {
                kilit_sar�.SetActive(false);
                PlayerPrefs.SetInt("sar�", 1);
                PlayerPrefs.SetInt("secilitop", 8);

                a = PlayerPrefs.GetInt("collected");
                a = a - 100;
                Skor.collect = a;
                PlayerPrefs.SetInt("collected", a);
                collecteds.text = "X " + PlayerPrefs.GetInt("collected").ToString();
                collected.text = "X" + "\n" + PlayerPrefs.GetInt("collected").ToString();

            }
        }
        else { PlayerPrefs.SetInt("secilitop", 8); }


    }
    void Update()
    {
        if(PlayerPrefs.GetInt("gri")==1)
        kilit_gri.SetActive(false);
        if (PlayerPrefs.GetInt("k�rm�z�") == 1)
            kilit_k�rm�z�.SetActive(false);
        if (PlayerPrefs.GetInt("mor") == 1)
            kilit_mor.SetActive(false);
        if (PlayerPrefs.GetInt("lacivert") == 1)
            kilit_lacivert.SetActive(false);
        if (PlayerPrefs.GetInt("sar�") == 1)
            kilit_sar�.SetActive(false);
        if (PlayerPrefs.GetInt("turkuaz") == 1)
            kilit_turkuaz.SetActive(false);
        if (PlayerPrefs.GetInt("ye�il") == 1)
            kilit_ye�il.SetActive(false);

        if (PlayerPrefs.GetInt("secilitop") == 1) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat1); }
        if (PlayerPrefs.GetInt("secilitop") == 2) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat2); }
        if (PlayerPrefs.GetInt("secilitop") == 3) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat3); }
        if (PlayerPrefs.GetInt("secilitop") == 4) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat4); }
        if (PlayerPrefs.GetInt("secilitop") == 5) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat5); }
        if (PlayerPrefs.GetInt("secilitop") == 6) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat6); }
        if (PlayerPrefs.GetInt("secilitop") == 7) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat7); }
        if (PlayerPrefs.GetInt("secilitop") == 8) { top.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat8); }

        



    }
}
