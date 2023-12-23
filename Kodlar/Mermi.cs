using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mermi : MonoBehaviour
{
    public float bs;
    public float Alive;
    public float damage;
    
    private Rigidbody2D rb2dd;
    
   
    
    Dusman dusman;
    private void Awake()
    {
    }
            

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.transform.Translate(Vector2.up * bs * Time.deltaTime);
        StartCoroutine(yokol());
        

    }

    IEnumerator yokol()
    {
        yield return new WaitForSeconds(Alive);
        Destroy(this.gameObject);
    }






     void OnTriggerEnter2D(Collider2D hit)
    {

        if (hit.gameObject.TryGetComponent<Dusman>(out Dusman dusmancompenent))
        {
            Destroy(gameObject);

            dusmancompenent.damageal(50);
        }
        Destroy(gameObject);
    }
}
