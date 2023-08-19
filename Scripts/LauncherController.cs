using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    [SerializeField] private Collider balls;
    [SerializeField] private float maxForce;
    [SerializeField] private float maxTime;
    private Renderer renderer;

    [SerializeField] private float force;
    private bool isHold = false;


    private void Start() {
        renderer = GetComponent<Renderer>();

    }
    private void OnCollisionStay(Collision other) {
        if (other.collider == balls){   
            //Rigidbody ballsrig = balls.GetComponent<Rigidbody>();
            ReadInput(balls);

        }
    }

    private void ReadInput(Collider other){
        if (Input.GetKey(KeyCode.Space) && !isHold){
            //other.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);

            StartCoroutine(StartHold(other));
        }

    }
    private IEnumerator StartHold(Collider other){
        isHold = true;
        float force = 0.0f;
        float timeHold = 0.0f;
        renderer.material.color = Color.blue;

        while (Input.GetKey(KeyCode.Space))
        {
            force = Mathf.Lerp(0, maxForce,timeHold/maxTime);
            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
            
        }
        renderer.material.color = Color.black;
        other.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }
}
