using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float returnTime;
    public float followSpeed;
    
    //public Transform target;
    public Transform target;
    private Vector3 defaultPosition;
    public Transform dummyTarget;
    public float length = 12.35f;
    public bool hasTarget {get {return target != null;}}

    

//5.71f
    private void Update() {
        if (hasTarget)
        {
            
        Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
        Vector3 targetPosition = target.position + (targetToCameraDirection * length);
        transform.position = Vector3.Lerp(transform.position,targetPosition, followSpeed * Time.deltaTime);
        }

    }
    private void Start() {
        defaultPosition = transform.position;   

    }

    

    public void FollowTarget(Transform targetTransform, float targetLength){
        
        StopAllCoroutines();
        target = targetTransform;
        length = targetLength;

    }

    public void GoBackToDefault(){
        target = null;
        StopAllCoroutines();
        //gerakan ke posisi default
        StartCoroutine(MovePosition(defaultPosition,returnTime));

    }
    private IEnumerator MovePosition(Vector3 target, float time){
        float timer = 0;
        Vector3 start = transform.position;
        while (timer < time){
            //pindahkan posisi camera secara bertahap
            transform.position = Vector3.Lerp(start,target, Mathf.SmoothStep(0.0f,1.0f,timer/time));

            timer += Time.deltaTime;

            yield return new WaitForEndOfFrame();

        }
        transform.position = target;
    }
}
