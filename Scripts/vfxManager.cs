using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vfxManager : MonoBehaviour
{    
    [SerializeField] private GameObject vfxSource;


    public void playVFX(Vector3 spawnPosition){
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    
    }
}
