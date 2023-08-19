using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button playGame;
    public Button exitGame;

    public void PlayGame(){
        SceneManager.LoadScene("Pinball_Game");
    }
    public void ExitGame(){
        Application.Quit();

    }

    
}
