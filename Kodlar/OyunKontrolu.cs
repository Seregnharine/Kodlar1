using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OyunKontrolu : MonoBehaviour
{
    public bool oyunDurdu;
    public atesvurus vurus;
    public GameObject pause;


    private void Start()
    {
        pause.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            
            if (oyunDurdu)
            
              OyunuDevamEttir();
                
            
            else
                OyunuDurdur();
        }
    }





    void OyunuDurdur()
    {
       

        pause.SetActive(true);
        Time.timeScale = 0f; // Oyun h�z�n� 0'a ayarlayarak oyunu duraklat�r.
        oyunDurdu = true;
        vurus.canfire = false;
    }

    void OyunuDevamEttir()
    {
        pause.SetActive(false);
        Time.timeScale = 1f; // Oyun h�z�n� tekrar 1'e ayarlayarak oyunu devam ettirir.
        oyunDurdu = false;
        vurus.canfire = true;
    }
}