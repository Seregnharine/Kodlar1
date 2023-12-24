using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemyhealthbar : MonoBehaviour
{

    public Slider slider;
    public Camera cam2;
    public Transform target3;
    void Start()
    {
        
    }

    void Update()
    {
        transform.rotation = cam2.transform.rotation;
        transform.position = target3.position;
    }


      public void updatehealthbar ( float currentvalue, float maxvalue)

      {
        slider.value = currentvalue / maxvalue;
        
      }
}
