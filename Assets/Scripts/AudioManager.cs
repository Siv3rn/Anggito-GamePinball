using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject sfxSource;
    void Start()
    {
        playBGM();
    }

    private void playBGM(){
        audioSource.Play();
        audioSource.loop = true;
    }
    public void playSFX(Vector3 spawnPosition){
        GameObject.Instantiate(sfxSource, spawnPosition, Quaternion.identity);
    
    }

}
