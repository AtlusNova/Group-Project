using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameLose : MonoBehaviour
{
    
    public GameObject loseUI;
    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        

        // only if you enter the "Enemy" object this activates 
        if (other.gameObject.name != "Key")
        {
            if (other.gameObject.name != "Exit")
            {

                Vector3 particleSpawnPoint = other.transform.position;
                Instantiate(explosionEffect, particleSpawnPoint, Quaternion.identity);
                Destroy(GameObject.Find("Player"));

                loseUI.SetActive(true);
            }
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
