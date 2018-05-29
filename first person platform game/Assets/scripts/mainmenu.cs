using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None; //lockstate is dat i vast zit in het midden van het scherm . 
        Cursor.visible = true; // visible .
    }

    public void changetoscene (int scenetochangeto)
    {
        SceneManager.LoadScene(scenetochangeto);
    }

    public void exitgame()
    {
        Application.Quit();
    } 
}
