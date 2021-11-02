using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameWin : MonoBehaviour
{

    public GameObject winUI;


    private void OnTriggerEnter(Collider other)
    {


        // only if you enter the "exit" object this activates 
        if (other.gameObject.name == "exit") 
        {
            Time.timeScale = 0;

            winUI.SetActive(true);
        }
        
    }
    public void LoadLevel(string name)
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
        Application.Quit();
        print("you quit the game");

    }

}
