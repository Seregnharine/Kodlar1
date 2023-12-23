using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class healt : MonoBehaviour
{
    public bool deadge;
    public Stats stat;
 
    public Healtbar healthBar;
    public GameObject pat;
    public GameObject tanktopu;
    public gameover game;
    AudioManager audio1;
    internal static healt instance;

    private void Awake()
    {
        audio1 = GameObject.FindGameObjectWithTag("Sesler").GetComponent<AudioManager>();
    }






    void Start()
    {
        stat.curenthealth = stat.maxhealth;
        healthBar.SetMaxhealth(stat.maxhealth);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
  


    public void Takedamage(int damage)
    {
        stat.curenthealth -= damage;
        healthBar.SetHealth(stat.curenthealth);


        if(stat.curenthealth <= 0 && deadge == false)
        {

            
            deadge = true;
            Instantiate(pat, transform.position, Quaternion.identity);
            audio1.Playsfx(audio1.tankpatlama);
            Destroy(this.gameObject);
            Destroy(tanktopu);
            game.enableded();


        }
    }




}
