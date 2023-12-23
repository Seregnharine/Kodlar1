using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;
    public float rotatesp;


    Vector2 movee;        


    
    void Start()

    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
    
    }







    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movee * speed * Time.fixedDeltaTime);

        float rotate = Input.GetAxisRaw("Horizontal");
        float move = Input.GetAxisRaw("Vertical");


        this.transform.Translate(0f, move * speed * Time.deltaTime, 0f);
        this.transform.Rotate(0f, 0f, -rotate * (rotatesp * 10) * Time.deltaTime);

       



    }









}



