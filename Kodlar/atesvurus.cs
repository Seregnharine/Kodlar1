using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class atesvurus : MonoBehaviour
{
    public float damage;
    public float firerate = 3;
    public Transform firepoint;
    public GameObject bullet;
    public GameObject cannon;
    public bool canfire;
    public OyunKontrolu kontrol;
    public int bulletsped;
     public AudioSource ateses;

    AudioManager audio1;

    private void Awake()
    {
        audio1 = GameObject.FindGameObjectWithTag("Sesler").GetComponent<AudioManager>();
    }

    private void Start()
    {
        ateses.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        vur();
        if (canfire == false) return; // if not allowed to shoot, don't run the code bellow

        
    }


    public void vur()
    {

        if (canfire == true )
        {
            if (Input.GetButtonDown("Fire1"))
            {
                shoot();
                StartCoroutine(Vurus1());
                canfire = false;
                 StartCoroutine(cooldown());
                CamShake.Instance.Shakecam(3f, 0.25f);
                audio1.Playsfx(audio1.tankates);








            }

        }
    }


    


     IEnumerator Vurus1()
    {
        cannon.transform.localPosition = new Vector2(cannon.transform.localPosition.x, cannon.transform.localPosition.y - 0.5f);
        yield return new WaitForSecondsRealtime(1);
        cannon.transform.localPosition = new Vector2(cannon.transform.localPosition.x, cannon.transform.localPosition.y + 0.5f);
        


    }



     IEnumerator cooldown()
     {
        if(kontrol.oyunDurdu == true)
        {
            canfire = false;
        }
        else
        {

           
            yield return new WaitForSecondsRealtime(1.5f);
            canfire = true;
        }

       
       
        
       

     }



    public void AllowShooting(bool status)
    {
        canfire = status;
    }



    void shoot ()
    {
       
            this.transform.Translate(Vector2.up * bulletsped * Time.deltaTime);
            Instantiate(bullet, firepoint.position, firepoint.rotation);

        


    }
}
