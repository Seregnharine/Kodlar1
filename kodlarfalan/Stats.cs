using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public static Stats Instance;
    public int maxhealth;
    public int curenthealth;
    [SerializeField] int currentexp, maxexp, currentleve;
    [SerializeField] int bulletdamage;
    public para para2;
    public Shopmanager manage;
    [SerializeField]
    private void Start()
    {
    }
    public void stats(int health)
    {
        this.maxhealth = health;
    }
    
    internal void Sum(Stats upgrade)
    {
        this.maxhealth += upgrade.maxhealth;
    }

    private void OnEnable()
    {
        Expmanager.Instance.onexpchange += handlexp;
    }
    private void OnDisable()
    {
        Expmanager.Instance.onexpchange -= handlexp;
    }

    private void handlexp(int newexp)
    {
        currentexp += newexp;
        if(currentexp >= maxexp)
        {
            upgrade();
        }
    }


    




    public void upgrade ()
    {
        curenthealth = maxhealth;
        currentleve++;
        maxhealth += 10;
        currentexp = 0;
        maxexp += 100;

    }


   
   
    
}
