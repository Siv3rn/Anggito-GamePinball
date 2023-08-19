using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampController : MonoBehaviour
{        
    [SerializeField] private Collider balls;

    [SerializeField] private ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other) {
        if (other == balls){   
                scoreManager.AddScore(2000);

        }
        
    }
}
