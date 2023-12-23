using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{

    [SerializeField] private float speed = 8f;
    [SerializeField] private float lifetime = 3f;
    private Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb2.velocity = transform.up * speed;
    }



  




    void OnTriggerEnter2D(Collider2D hit)
    {

        if (hit.gameObject.TryGetComponent<healt>(out healt healt1))
        {

            healt1.Takedamage(15);
            Destroy(this.gameObject);
        }
    }
}
