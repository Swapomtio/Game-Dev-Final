using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("HunterSelection");
    }
    public void Instructions(){
        SceneManager.LoadScene("InstructionMenu");
    }
    public void Settings(){
        SceneManager.LoadScene("OptionsMenu");
    }
    public void QuitGame(){
        Application.Quit(); //this will not work in the editor need to build to do this
    }
}
