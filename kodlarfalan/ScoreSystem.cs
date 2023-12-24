using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ScoreSystem : MonoBehaviour
{
    public  int scorevalue = 0;
    public TextMeshProUGUI scoretext;

    void Start()
    {
        scoretext.text = "Coins:" + scorevalue.ToString();
        scorevalue = PlayerPrefs.GetInt("Amount1");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Coins:" + scorevalue.ToString();
        scoretext.text = "Coins:" + scorevalue;
        PlayerPrefs.SetInt("Amount1", scorevalue);
    }
}
