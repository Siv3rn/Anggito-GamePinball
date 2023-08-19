using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomOutController : MonoBehaviour
{
    [SerializeField] private Collider balls;
    [SerializeField] private CameraController camera;
    public float length;


    private void OnTriggerEnter(Collider other) {
        if (other == balls)
        {
            camera.GoBackToDefault();
        }
    }

}
