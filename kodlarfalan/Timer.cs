using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public GameObject obje;

    public float timeremainig = 0;
    public bool timeisruning = true;
    public TMP_Text timetext;
    private void Start()
    {
        timeisruning = true;
    }

    private void Update()
    {
        if(timeisruning)
        {
            if(timeremainig >= 0)
            {
                timeremainig += Time.deltaTime;
                Displaytime(timeremainig);
            }
        }

        if (timeremainig >= 5)
        {
            Destroy(obje);
        }
    }



    void Displaytime (float timetodisplay)
    {
        timetodisplay += 1;
        float minutes = Mathf.FloorToInt(timetodisplay / 60);
        float seconds = Mathf.FloorToInt(timetodisplay % 60);
        timetext.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    


}
