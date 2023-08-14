using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminrenkeşitleyici : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material mat5;
    public Material mat6;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (TopHareketi.secili_zemin == 1) { this.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat1); }
        if (TopHareketi.secili_zemin == 2) { this.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat2); }
        if (TopHareketi.secili_zemin == 3) { this.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat3); }
        if (TopHareketi.secili_zemin == 4) { this.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat4); }
        if (TopHareketi.secili_zemin == 5) { this.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat5); }
        if (TopHareketi.secili_zemin == 6) { this.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(mat6); }

    }
}
