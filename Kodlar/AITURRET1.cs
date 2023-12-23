using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITURRET1 : MonoBehaviour
{
    public AIDeneme aý;
    public Transform target1;
    [SerializeField] float rotatesp1;
    [SerializeField] float shootdistance = 5f;
    [SerializeField] Transform firingpoint;
    public GameObject bullet1;
    private float timetofire;
    [SerializeField] float firearate;
    public GameObject bullet;

    private void Start()
    {
        timetofire = firearate;
    }

    // Update is called once per frame
    void Update()
    {
        if (target1)
        {
            gettarget();
        }
        else
        {
            rotatetarget();
        }



        if (Vector2.Distance(target1.position, transform.position) <= shootdistance)
        {
            shooting();
        }
    }


    private void rotatetarget()
    {
        Vector2 targetdirect = aý.target.position - transform.position;
        float angle = Mathf.Atan2(targetdirect.y, targetdirect.x) * Mathf.Rad2Deg -0.1f;
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotatesp1);
    }



    private void gettarget()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            target1 = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }



    private void shooting()
    {
        if (timetofire <= 0f)
        {
            Instantiate(bullet, firingpoint.position, firingpoint.rotation);
            timetofire = firearate;
        }
        else
        {
            timetofire -= Time.deltaTime;
        }
    }




    public void Aim(Vector2 inputPointerPosition)
    {
        var turretDirection = (Vector3)inputPointerPosition - transform.position;

        var desiredAngle = Mathf.Atan2(turretDirection.y, turretDirection.x) * Mathf.Rad2Deg;

        var rotationStep = rotatesp1 * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, desiredAngle), rotationStep);
    }
}
