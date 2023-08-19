using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    private HingeJoint hinge;
    [SerializeField] private float targetPressed;
    [SerializeField] private float targetRelease;
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
    }

    private void ReadInput(){
        JointSpring jointSpring = hinge.spring;

        if(Input.GetKey(input)){
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            jointSpring.targetPosition = targetRelease;
        }

        hinge.spring = jointSpring;
    }
}
