using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healtbar : MonoBehaviour
{

    public Slider slider1;
  
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMaxhealth(int health)
    {
        slider1.maxValue = health;
        slider1.value = health;
    }


    public void SetHealth (int health1)
    {
        slider1.value = health1;
    }



   
}
