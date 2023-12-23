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




//Bu örnekte, düþman nesneleri 'Enemy' bileþenine sahiptir. Bu bileþen, 'moneyReward' deðiþkenine sahiptir, bu da öldürülen düþmanýn oyuncuya ne kadar para kazandýracaðýný belirler. Düþman öldürüldüðünde, 'GameManager.Instance.Money' deðiþkeni bu para miktarýna eklenir ve düþman nesnesi yok edilir.

//GameManager sýnýfýnýzý özellikle oluþturmadýysanýz, bir Singleton yapabilirsiniz. Aþaðýdaki örnekte, GameManager, Money isimli bir static integer deðiþken içeriyor.

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


