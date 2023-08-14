using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public static int collect;
    public static int skor;
    public Text skortext;
    public Text high;
    public Text collected;
    public Text collecteds;
    void Start()
    {
        collecteds.text= "X "  + PlayerPrefs.GetInt("collected").ToString();
        collected.text =  "X" + "\n" + PlayerPrefs.GetInt("collected").ToString();
        high.text = "High Score : " + PlayerPrefs.GetInt("high").ToString();
        skor = 0;
        
    }

   
    void Update()
    {

        skortext.text=skor.ToString();
        if (skor > PlayerPrefs.GetInt("high")) { PlayerPrefs.SetInt("high", skor); }
     

    }
}
