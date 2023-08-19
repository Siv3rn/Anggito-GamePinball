using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour{
    [SerializeField] private Collider balls;
    [SerializeField] private float multiplier = 2.0f;
    private Animator animator;
    private Renderer renderer;

    [SerializeField] private AudioManager audioManager;
    [SerializeField] private vfxManager vfxManager;
    [SerializeField] private ScoreManager scoreManager;

    private void Start() {
        animator = GetComponent<Animator>();
        renderer = GetComponent<Renderer>();
        
    }
    private void OnCollisionEnter(Collision other) {
        // if (other.gameObject.CompareTag("Balls")){
        //     Debug.Log("berhasil");
        // }

        if (other.collider == balls){   
            Rigidbody ballsrig = balls.GetComponent<Rigidbody>();
            ballsrig.velocity *= multiplier;
            animator.SetTrigger("hit");

            //playsfx
            audioManager.playSFX(other.transform.position);

            //playvfx
            vfxManager.playVFX(other.transform.position);
            //add score

            scoreManager.AddScore(100);   
        }
    }
    
}
