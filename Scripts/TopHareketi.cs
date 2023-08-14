using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopHareketi : MonoBehaviour
{
    
    Vector3 yön;
    public float hýz;
    public ZeminSpawner zeminspwanerscripti;

    public static int collect;
    public static bool düþtü_mü;
    public float eklenecekhýz;
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
        yön = Vector3.forward; 
        düþtü_mü = false;
       audioSource = GetComponent<AudioSource>();        
    }

   
    void Update()
    {
        if (transform.position.y <= 0.5f) 
        { düþtü_mü = true;
            bitti_btn.SetActive(true);         
        }
        if (düþtü_mü == true)
        {
            return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            if (UI.ses1 == true) { audioSource.PlayOneShot(yon); }
            
            if (yön.x == 0) 
            {
                yön = Vector3.left;
            }
            else 
            {
                yön = Vector3.forward;
            }
            

        }
    }

   
    private void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * hýz;
        transform.position += hareket;
    }
    
    private void OnCollisionExit(Collision collision)
    {
        

        if(collision.gameObject.tag=="zemin")
        {

            hýz += eklenecekhýz * Time.deltaTime;

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
            zeminspwanerscripti.zemin_oluþtur();
            StartCoroutine(ZeminiSil(collision.gameObject));
        }
    }

    public void tekrar_oyna() 
    {
        AdManager.reklama++;
        SceneManager.LoadScene("SampleScence");
        hýz = 0;
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
