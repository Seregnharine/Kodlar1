using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void playgame ()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void quit()
    {
        Application.Quit();
    }

    public void Reset()
    {
        SceneManager.LoadScene("oyun");
    }
}
