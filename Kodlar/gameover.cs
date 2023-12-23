using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{

    public GameObject ded;


    private void Start()
    {
        ded.SetActive(false);
    }

    public void enableded()
    {
        ded.SetActive(true);
    }
}
