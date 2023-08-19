using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateController : MonoBehaviour
{    
    [SerializeField] private Collider balls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnTriggerEnter(Collider other) {
        // if (other.gameObject.CompareTag("Balls")){
        //     Debug.Log("berhasil");
        // }
        if (other == balls){   
            Rigidbody ballsrig = balls.GetComponent<Rigidbody>();
            //transform.position = transform.position * 3 * Time.deltaTime;
            ballsrig.velocity *= 1.5f;
        }

    }
}
