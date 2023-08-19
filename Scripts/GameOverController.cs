using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private Collider balls;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject[] paddles;

    private void Start() {
        paddles = GameObject.FindGameObjectsWithTag("Paddle");
    }

    private void OnTriggerEnter(Collider other) {
        if (other == balls){   
            Debug.Log("lost");
            gameOverUI.SetActive(true);
            foreach (var paddle in paddles){
            paddle.GetComponent<PaddleController>().enabled = false;  
            }

        }
    }
        
    

    // private void OnTriggerStay(Collider other) {
    //     if (other == balls){   
    //         Debug.Log("lost");
    //     }
    // }

}
