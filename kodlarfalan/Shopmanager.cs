using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Shopmanager : MonoBehaviour
{
   
    public static Shopmanager instance;
    public Text coin;
    public TextMeshProUGUI tm;
    public GameObject Shopu�;
    public GameObject prefabitem;
    public move player;
    public Transform shopcont;
    public para para2;
    public Mermi mermi;
    public healt Healt;
    public int plushealth = 15;
    public Stats stat;
    public int damage;

    [Header("para")]

    [Header("objeler")]
    public int[,] shopitems = new int[5, 5];





    private void OnEnable()
    {
        BuyDamage();
    }

    public void Start()
    {
        coin.text = "Coins:" + para2.para1.ToString();
        // ID
        shopitems[1, 1] = 1;
        shopitems[1, 2] = 2;
        shopitems[1, 3] = 3;
        shopitems[1, 3] = 4;
        // Fiat
        shopitems[2, 1] = 150;
        shopitems[2, 2] = 100;
        shopitems[2, 3] = 200;
        shopitems[2, 3] = 0;
        // adet
        shopitems[3, 1] = 0;
        shopitems[3, 2] = 0;
        shopitems[3, 3] = 0;
        shopitems[3, 3] = 0;


    }

    public void Buyspeed()
    {
        GameObject buttonref = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (para2.para1 >= shopitems[2, buttonref.GetComponent<Butonlar>().item�d])
        {
            para2.para1 -= shopitems[2, buttonref.GetComponent<Butonlar>().item�d];
            shopitems[3, buttonref.GetComponent<Butonlar>().item�d]++;
            coin.text = "Coins:" + para2.para1.ToString();
            buttonref.GetComponent<Butonlar>().adet.text = shopitems[3, buttonref.GetComponent<Butonlar>().item�d].ToString();
            buttonref.GetComponent<Butonlar>().fiat.text = shopitems[2, buttonref.GetComponent<Butonlar>().item�d].ToString();
            player.speed += 5f;
        }
    }


    public void Buyslow()
    {
        GameObject buttonref = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (para2.para1 >= shopitems[2, buttonref.GetComponent<Butonlar>().item�d])
        {
            para2.para1 -= shopitems[2, buttonref.GetComponent<Butonlar>().item�d];
            shopitems[3, buttonref.GetComponent<Butonlar>().item�d]++;
            coin.text = "Coins:" + para2.para1.ToString();
            buttonref.GetComponent<Butonlar>().adet.text = shopitems[3, buttonref.GetComponent<Butonlar>().item�d].ToString();
            mermi.bs += 5;
            
        }
    }





    public void BuyDamage()
    {
        GameObject buttonref = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (para2.para1 >= shopitems[2, buttonref.GetComponent<Butonlar>().item�d])
        {
            para2.para1 -= shopitems[2, buttonref.GetComponent<Butonlar>().item�d];
            shopitems[3, buttonref.GetComponent<Butonlar>().item�d]++;
            coin.text = "Coins:" + para2.para1.ToString();
            buttonref.GetComponent<Butonlar>().adet.text = shopitems[3, buttonref.GetComponent<Butonlar>().item�d].ToString();
            stat.maxhealth += 5;

        }
    }


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void toggleshop()
    {
        Shopu�.SetActive(!Shopu�.activeSelf);
    }



    



    private void OnGUI()
    {
        coin.text = "Coins:" +para2.para1.ToString();
    }



    [System.Serializable]
    public class itemler
     {  

        public string name;
        public Sprite image;
        public int cost;
        public bool alimdurum;
        

        public itemler(string Name, Sprite Image, int Cost,bool Alimdurum)
        {
            name = Name;
            image = Image;
            cost = Cost;
            alimdurum = Alimdurum;
        }

     } 





}

