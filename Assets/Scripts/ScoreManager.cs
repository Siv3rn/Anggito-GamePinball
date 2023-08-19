using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float score = 0;


    private void Start() {
        Reset();
    }

    public void AddScore(float addition){
        score+=addition;
    }
    public void Reset(){
        score = 0;
    }

}
