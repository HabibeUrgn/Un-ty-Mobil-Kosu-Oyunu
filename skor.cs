using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class skor : MonoBehaviour
{
    public TMP_Text yıldızyazısı;
    public float yıldızsayısı;
    void Start()
    {
        
    }
    void Update()
    {
        yıldızyazısı.text = "Skor: " + yıldızsayısı;
    }
}
