using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{

    public GameObject son_zemin;

    public GameObject kup;
    void Start()
    {
        for (int i = 0; i < 200; i++)
        {
            zemin_oluþtur();

        }
    }


    void Update()
    {

    }

    public void zemin_oluþtur()
    {
     
        Vector3 yön;
        
        Vector3 a = new Vector3(0, 2, 0);

        if (Random.Range(0,2) == 0) 
        {
            
            
            yön = Vector3.left;
        }
        else 
        {
            
            yön = Vector3.forward;
        }
        if (Random.Range(0, 5) == 0)
        {
            kup = Instantiate(kup, son_zemin.transform.position + a, son_zemin.transform.rotation);
        }
        son_zemin = Instantiate(son_zemin, son_zemin.transform.position + yön, son_zemin.transform.rotation);
    }

}
