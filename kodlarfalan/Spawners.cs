using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    [SerializeField] GameObject enemytank;
    //[SerializeField] Vector2 spawns;
    [SerializeField] float sure;
    AIDestinationSetter set;
    [SerializeField] Vector2 spawnarea;
    
    [SerializeField] GameObject player;
    float timer;


    private void Start()
    {
        timer = sure;
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <0f)
        {
            timer = sure;
            Spawn();
           
        }
    }

    private void Spawn()
    {
        Vector3 position = new Vector3(
        UnityEngine.Random.Range(-spawnarea.x, spawnarea.x),
        UnityEngine.Random.Range(-spawnarea.y, spawnarea.y),
        0f);

        GameObject newenemy = Instantiate(enemytank);
        newenemy.transform.position = position;
        newenemy.GetComponent<Dusman>().Settarget(player);
        
    }
}
