using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PauseMenu : MonoBehaviour
{
    bool isPaused = false;
    public GameObject pauseUI;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            togglePause();
        }

}
    public void togglePause()
    {

        if (isPaused)
        {
            //unpause
            Time.timeScale = 1;
            isPaused = false;

            pauseUI.SetActive(false);
        }
        else 
        {
            //pause
            Time.timeScale = 0;
            isPaused = true;

            pauseUI.SetActive(true);
        }

        //sets isPaused to its inverse value
        //isPaused = !isPaused;
    }

    public void Quit()
    {
        Application.Quit();


    }
}
