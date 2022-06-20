using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;



public class karakter : MonoBehaviour
{
    public sagtus satus;
    public sol soltus;
    public zıplama zıp;
    public Rigidbody rg;
    public Animator ani;
    public GameObject Karakter;
    public Transform yol1,yol2;
    public skor yıldızskor;
    public GameObject yıldızefect;

    void Start()
    {
        
    }


    public void OnTriggerEnter(Collider nesne){
        if (nesne.gameObject.tag == "yol1")  {
            yol2.position = new Vector3(yol1.position.x,yol1.position.y,yol1.position.z + 20.0f); 
        }

        if (nesne.gameObject.tag == "yol2")  {
            yol1.position = new Vector3(yol2.position.x,yol2.position.y,yol2.position.z + 20.0f); 
        }
        if (nesne.gameObject.tag == "altın") {
            yıldızskor.yıldızsayısı += Random.Range(1,2);
            GameObject yeniefect = Instantiate(yıldızefect,nesne.gameObject.transform.position,Quaternion.identity);
            Destroy(nesne.gameObject);
        }
        if (nesne.gameObject.tag == "engel") {
            Time.timeScale = 0.0f;
        }
        
    }

    void Update()
    {
        
        transform.Translate(0,0,4 * Time.deltaTime);
        // if (zıp.zıpla)
        // {
        //     rg.velocity = Vector3.up * 700.0f * Time.deltaTime; 
        //     ani.SetBool("zıpla",true);
        //     Invoke("zıplakapat",0.4f);
        // }
        if (satus.sag)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(2.05f, transform.position.y, transform.position.z),Time.deltaTime * 3.0f);
        }
        if (soltus.Sol)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-2.08f,transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
        }
    }


    public void zıpla()
    {
        rg.velocity = Vector3.up * 100.0f * Time.deltaTime; 


        Karakter.GetComponent<Animator>().Play("zıplamak");

        // ani.SetBool("zıpla",true);
        // Invoke("zıplakapat",0.4f);
    }

    public void zıplakapat()
    {
        ani.SetBool("zıpla",false);
    }
   
}
