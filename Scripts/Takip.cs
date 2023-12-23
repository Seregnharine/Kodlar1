using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takip : MonoBehaviour
{
    public bool awareofplayer { get; private set; }
    public Vector2 Directionplayer { get; private set; }
    public float _playerdistance;
    public Transform Player;
    void Awake ()
    {
        Player = FindAnyObjectByType<TankMover>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyvector = Player.position - transform.position;
        Directionplayer = enemyvector.normalized;
        if(enemyvector.magnitude <= _playerdistance)
        {
            awareofplayer = true;
        }
        else
        {
            awareofplayer = false;
        }
    }
}
