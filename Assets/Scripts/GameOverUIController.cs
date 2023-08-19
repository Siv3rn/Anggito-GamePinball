using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOverUIController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button restartGame;
    public Button returnGame;


    public void RestartGame(){
        SceneManager.LoadScene("Pinball_Game");
    }
    public void ExitGame(){
        SceneManager.LoadScene("MainMenu");

    }

}
