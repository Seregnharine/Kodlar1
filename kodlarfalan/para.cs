using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class para : MonoBehaviour
{
    public static para instance;
    public int para1;
    public TextMeshProUGUI tm;
    public Dusman dusman;
    
    void Start()
    {
        para1 = PlayerPrefs.GetInt("Amount");
    }

    private void Update()
    {
        tm.text = "" + para1;
        tm.text = para1.ToString();
        PlayerPrefs.SetInt("Amount", para1);
    }


    

}
