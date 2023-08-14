using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopHareketi : MonoBehaviour
{
    
    Vector3 y�n;
    public float h�z;
    public ZeminSpawner zeminspwanerscripti;

    public static int collect;
    public static bool d��t�_m�;
    public float eklenecekh�z;
    public AudioSource audioSource;
    public AudioClip yon;
    public AudioClip coin;
    public AudioClip basla;
    public AudioClip helal;
    public GameObject bitti_btn;
    public GameObject Name;
    public static int secili_zemin;
 
    void Start()
    {
        secili_zemin = 1;
        y�n = Vector3.forward; 
        d��t�_m� = false;
       audioSource = GetComponent<AudioSource>();        
    }

   
    void Update()
    {
        if (transform.position.y <= 0.5f) 
        { d��t�_m� = true;
            bitti_btn.SetActive(true);         
        }
        if (d��t�_m� == true)
        {
            return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            if (UI.ses1 == true) { audioSource.PlayOneShot(yon); }
            
            if (y�n.x == 0) 
            {
                y�n = Vector3.left;
            }
            else 
            {
                y�n = Vector3.forward;
            }
            

        }
    }

   
    private void FixedUpdate()
    {
        Vector3 hareket = y�n * Time.deltaTime * h�z;
        transform.position += hareket;
    }
    
    private void OnCollisionExit(Collision collision)
    {
        

        if(collision.gameObject.tag=="zemin")
        {

            h�z += eklenecekh�z * Time.deltaTime;

            Skor.skor++;
            if (Skor.skor > 1)
            {
                if (Skor.skor % 50 == 0)
                {
                    {
                        if (UI.ses1 == true) { audioSource.PlayOneShot(helal); }
                        secili_zemin += 1;
                    }
                }
            }
            collision.gameObject.AddComponent<Rigidbody>();
            zeminspwanerscripti.zemin_olu�tur();
            StartCoroutine(ZeminiSil(collision.gameObject));
        }
    }

    public void tekrar_oyna() 
    {
        AdManager.reklama++;
        SceneManager.LoadScene("SampleScence");
        h�z = 0;
        secili_zemin = 1;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kup")
        {
            if (UI.ses1 == true) { audioSource.PlayOneShot(coin); }
            Skor.collect++;
            PlayerPrefs.SetInt("collected", Skor.collect);
            other.gameObject.SetActive(false);
        }
    }
    

IEnumerator ZeminiSil(GameObject SilinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);
    }
}
