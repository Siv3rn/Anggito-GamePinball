using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class SwitchController : MonoBehaviour
{    
    private enum SwitchState{ 
            on,
            off,
            blink
        };
    [SerializeField] private Collider balls;
    [SerializeField] private Material offMaterial;
    [SerializeField] private Material onMaterial;
    private SwitchState State;
    private Renderer renderer;
    [SerializeField] private ScoreManager scoreManager;



    private void Start() 
    {
        renderer = GetComponent<Renderer>();
        StartCoroutine(StartBlinking(5));

    }
    
    private void SetSwitch(bool active){
        if (active)
        {
            State = SwitchState.on;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            State = SwitchState.off;
            renderer.material = offMaterial;
            StartCoroutine(StartBlinking(5));


        }


    }
    private void OnTriggerEnter(Collider other) 
    {
        
        if (other == balls)
        {
            Toggle();
            Debug.Log("nice");
        }
    }

    private void Toggle()
    {
        if (State == SwitchState.on)
        {

            SetSwitch(false);
        }
        else
        {

            SetSwitch(true);
        }
        scoreManager.AddScore(500);

    }

    private IEnumerator Blink(int times)
    {
        State = SwitchState.blink;

        for(int i=0; i<times; i++){
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);

        }
        State = SwitchState.off;        
        StartCoroutine(StartBlinking(5));
    }
    private IEnumerator StartBlinking(float second){
        yield return new WaitForSeconds(second);
        StartCoroutine(Blink(2));

    }

    // private async void OnTriggerExit(Collider other) {
    //     if (other == balls){
    //         await Task.Delay(2000);
    //         SetSwitch(false);
    //         Debug.Log("nice");
    //         }
    // }
}
