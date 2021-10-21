using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameWin : MonoBehaviour
{

    public GameObject winUI;


    private void OnTriggerEnter(Collider other)
    {


        // only if you enter the "exit" object this activates 
        if (other.gameObject.name == "exit") 
        { 
            winUI.SetActive(true);
        }
        
    }
    public void Quit()
    {
        Application.Quit();
        print("you quit the game");

    }

}
