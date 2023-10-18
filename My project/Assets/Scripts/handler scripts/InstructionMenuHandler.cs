using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InstructionMenuHandler : MonoBehaviour
{
    public void MainMenu(){
        Debug.Log("Go to Menu");
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame(){
        Application.Quit(); //this will not work in the editor need to build to do this
    }
}
