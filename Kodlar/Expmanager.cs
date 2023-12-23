using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expmanager : MonoBehaviour
{

    public static Expmanager Instance;
    public delegate void Exphandler(int amount);
    public event Exphandler onexpchange;
    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        
    }


    public void addexp(int amount)
    {
        onexpchange?.Invoke(amount);
    }
}
