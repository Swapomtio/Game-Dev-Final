using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HunterMenuHandler : MonoBehaviour
{
    public void Derpus(){
        SceneManager.LoadScene("Level");
    }
    public void MainMenu(){
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame(){
        Application.Quit(); //this will not work in the editor need to build to do this
    }
}
