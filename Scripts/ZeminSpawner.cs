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
            zemin_olu�tur();

        }
    }


    void Update()
    {

    }

    public void zemin_olu�tur()
    {
     
        Vector3 y�n;
        
        Vector3 a = new Vector3(0, 2, 0);

        if (Random.Range(0,2) == 0) 
        {
            
            
            y�n = Vector3.left;
        }
        else 
        {
            
            y�n = Vector3.forward;
        }
        if (Random.Range(0, 5) == 0)
        {
            kup = Instantiate(kup, son_zemin.transform.position + a, son_zemin.transform.rotation);
        }
        son_zemin = Instantiate(son_zemin, son_zemin.transform.position + y�n, son_zemin.transform.rotation);
    }

}
