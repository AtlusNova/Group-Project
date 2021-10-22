using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameLose : MonoBehaviour
{



    public GameObject loseUI;
    public GameObject loseEffect;

    private void OnTriggerEnter(Collider other)
    {

        
       



        
       
        
        
        // only if you enter the "Enemy" object this activates 
        if (other.gameObject.name == "Enemy")
        {

            //Destroy(this.gameObject);
            Destroy(GameObject.Find("Player"));


            Vector3 particleSpawnPoint = other.transform.position;
            Instantiate(loseEffect, particleSpawnPoint, Quaternion.identity);

            loseUI.SetActive(true);
        }

    }

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void Quit()
    {
        Application.Quit();
        //print("you quit the game");
    }
}
