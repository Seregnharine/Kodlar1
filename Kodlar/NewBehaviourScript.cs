using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
   
    public int moneyReward = 10;
    public TextMesh textMesh;

    public void Die()
    {
        GameManager.Instance.Money += moneyReward;
        Destroy(gameObject);
    }



    private void Update()
    {
        textMesh.text = "" + moneyReward;
    }
}




//Bu �rnekte, d��man nesneleri 'Enemy' bile�enine sahiptir. Bu bile�en, 'moneyReward' de�i�kenine sahiptir, bu da �ld�r�len d��man�n oyuncuya ne kadar para kazand�raca��n� belirler. D��man �ld�r�ld���nde, 'GameManager.Instance.Money' de�i�keni bu para miktar�na eklenir ve d��man nesnesi yok edilir.

//GameManager s�n�f�n�z� �zellikle olu�turmad�ysan�z, bir Singleton yapabilirsiniz. A�a��daki �rnekte, GameManager, Money isimli bir static integer de�i�ken i�eriyor.

public class GameManager
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }
            return _instance;
        }
    }

    public int Money { get; set; }
}


