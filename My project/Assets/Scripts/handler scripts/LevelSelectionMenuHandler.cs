using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionMenuHandler : MonoBehaviour
{
    public void BeginnerLevel(){
        SceneManager.LoadScene("Beginner Level A");
    }
    public void MediumLevel(){
        SceneManager.LoadScene("Middle Level A");
    }
    public void HardLevel(){
        SceneManager.LoadScene("Hard Level A");
    }
    public void MainMenu(){
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame(){
        Application.Quit(); //this will not work in the editor need to build to do this
    }
}
