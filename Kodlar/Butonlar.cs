using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Butonlar : MonoBehaviour

{
    public int item�d;
    public Text fiat;
    public Text adet;
    public GameObject shopmanager;

    // Update is called once per frame
    void update ()
    {
        fiat.text = "fiat:" + shopmanager.GetComponent<Shopmanager>().shopitems[2, item�d].ToString();
        adet.text =  shopmanager.GetComponent<Shopmanager>().shopitems[3, item�d].ToString();
    }
}
