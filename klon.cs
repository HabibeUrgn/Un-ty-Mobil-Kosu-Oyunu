using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klon : MonoBehaviour
{
    public float sagkısım = 2.44f;
    public float solkısım = -1.81f; 
    public float ortakısım = 0.53f;
    public GameObject altın, kup;
    public Transform karakter; 
    void Start()
    {
        InvokeRepeating("klonla" ,0,1.0f);
    }
    public void klonla() {
        int sayı = Random.Range(0,100);
        if(sayı > 45 && sayı < 100) {
            olustur(altın, 1.0f);
        }

        if (sayı > 90)
        {
            olustur(kup, 1.0f);
        }
    }
    public void olustur(GameObject nesne,float üst) {
        GameObject yeniklon = Instantiate(nesne);
        int sayı = Random.Range(0,100);
        if(sayı < 50) {
            yeniklon.transform.position = new Vector3(sagkısım,üst,karakter.position.z + 30.0f);
        }
        if(sayı > 50)
        {
            yeniklon.transform.position = new Vector3(solkısım,üst,karakter.position.z + 30.0f);
            
        }
        if(sayı > 30)
        {
            yeniklon.transform.position = new Vector3(ortakısım,üst,karakter.position.z + 30.0f);

        }
        Destroy(yeniklon, 10.0f);
    }
}
