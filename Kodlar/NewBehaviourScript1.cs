using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using System.Data;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public GameObject enemy;
    //public float enemyinterval = 3;
    public float sure1;
    int tanksayisi = 7;


    private void Start()
    {
        
    }





    void Update()
    {
        if (tanksayisi <= 0)
        {
            StartCoroutine(Vave());
        }

        if(tanksayisi > 0)
        {
            Instantiate(enemy, new Vector2(Random.Range(-5f, 5), Random.Range(-6f, 6f)), Quaternion.identity);
            tanksayisi--;

        }
    }

    IEnumerator Vave()
    {
        yield return new WaitForSecondsRealtime(sure1);
        tanksayisi++;
    }








    //private IEnumerator spawn(float interval , GameObject enemy)

    //yield return new WaitForSecondsRealtime(interval);
    //GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
    //StartCoroutine(spawn(interval, enemy))

 






}
