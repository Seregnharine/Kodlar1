using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dusman : MonoBehaviour
{

    GameObject targetobject;
    public static Dusman Instance;
    public GameObject image;
    public GameObject obje;
    public int health;
    public int MMaxhealth;
    public para para2;
    Enemyhealthbar healtbar1;
    public GameObject healthbar;
    [SerializeField] int expamount = 100;
    AIDestinationSetter set;
    public ScoreSystem score;
    public AIDetector detect;
   
    
   
    // Start is called before the first frame update



    private void Awake()
    {
        healtbar1 = GetComponentInChildren<Enemyhealthbar>();
    }
    void Start()
    {
        
        
        healthbar.SetActive(false);
        health = MMaxhealth;
        healtbar1.updatehealthbar(health, MMaxhealth);
    }
    private void Update()
    {
        Vector3 direct = (set.target.position - transform.position).normalized;
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
       
    }

   






    public void damageal (int damage)
    {
        health -= damage;
        healtbar1.updatehealthbar(health,MMaxhealth);
        if( health <= 0)
        {

            GetComponentInParent<AIPatrolStaticBehaviour>().enabled = false;
            GetComponentInChildren<AIDetector>().enabled = false;
            GetComponent<AIPath>().enabled = false;
            Instantiate(image, transform.position, Quaternion.identity);
            Destroy(obje.gameObject, 5f);
            para2.para1 += 5;
            score.scorevalue += 100;
            Expmanager.Instance.addexp(expamount);


            if (MMaxhealth == 150 && health <= 0)
            {
                Instantiate(image, transform.position, Quaternion.identity);
                Destroy(obje.gameObject);
                para2.para1 += 25;
            }
        }
    }



    


  
    

    private void OnMouseEnter()
    {
        healthbar.SetActive(true);
    }

    private void OnMouseExit()
    {
        healthbar.SetActive(false);
    }


    public void Settarget(GameObject target)
    {
        targetobject = target;
        set.target = target.transform;
    }









}
