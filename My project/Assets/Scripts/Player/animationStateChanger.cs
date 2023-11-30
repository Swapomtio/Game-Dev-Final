using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateChanger : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] string currentState = "Idle";

    // Start is called before the first frame update
    void Start()
    {
        ChangeAnimationState(currentState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeAnimationState(string newAnimationState, float speed = 1){


        animator.speed = speed;

        if(newAnimationState == currentState){
            return; //skip the change
        }

        currentState = newAnimationState;
        animator.Play(newAnimationState);
    }
}
