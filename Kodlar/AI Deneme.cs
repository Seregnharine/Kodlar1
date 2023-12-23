using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDeneme : MonoBehaviour
{
    public Transform target;
    [SerializeField] float speed1;
    [SerializeField] float rotatesp1;
    Vector2 _targetdirection;
    Vector2 movement;
    [SerializeField] float shootdistance = 5f;
    [SerializeField] float stopdistance = 3f;
    [SerializeField] Transform firingpoint;
    public GameObject bullet;


    [SerializeField] float firearate;
    private float timetofire;
    Rigidbody2D rb1;

    private void Start()
    {
        timetofire = firearate;
    }
    private void Awake()
    {
        rb1 = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(!target)
        {
            gettarget();
        }
        else
        {
            rotatetarget();
        }

        if (target != null && Vector2.Distance(target.position, transform.position) <= shootdistance)
        {
            shooting();
        }
    }

    private void FixedUpdate()
    {
        if(target != null)
        {

            if (Vector2.Distance(target.position, transform.position) >= stopdistance)
            {
                rb1.velocity = transform.up * speed1;
            }
            else
            {
                rb1.velocity = Vector2.zero;
            }

        }

        if(target = null)
        {
            rb1.velocity = Vector2.zero;
        }
        
        
        //Vector3 direction = (target.position - transform.position).normalized;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb1.rotation = angle;
        //rb1.velocity = direction * speed1;
        
        //rb1.MovePosition(rb1.position + movement * speed1 * Time.fixedDeltaTime);
        //this.transform.Translate(0f,   speed1 * Time.deltaTime, 0f);
        //this.transform.Rotate(0f, 0f,  rotatesp1 * 5 * Time.deltaTime);
        //rb1.velocity = Vector2.MoveTowards(transform.position, transform.position, speed1 * Time.deltaTime);
        //rb1.MoveRotation(transform.rotation * Quaternion.Euler(0, 0, -movement.x * rotatesp1 * Time.fixedDeltaTime));
    }

    private void rotatetarget()
    {
        Vector2 targetdirect = target.position - transform.position;
        float angle = Mathf.Atan2(targetdirect.y, targetdirect.x) * Mathf.Rad2Deg -0.1f;
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotatesp1);
    }


    private void gettarget()
    {
        if(GameObject.FindGameObjectWithTag("Player"))
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }



    private void shooting()
    {
        if(timetofire<= 0f)
        {
            Instantiate(bullet, firingpoint.position, firingpoint.rotation);
            timetofire = firearate;
        }
        else
        {
            timetofire -= Time.deltaTime;
        }
    }
}