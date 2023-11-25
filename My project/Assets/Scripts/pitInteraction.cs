using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitInteraction : MonoBehaviour
{
    CapsuleCollider2D capsuleCollider;
    // Start is called before the first frame update
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (other is CapsuleCollider2D)
            {
                Debug.Log("Player entered the Pit's capsule collider trigger area!");
            }
            else if (other is BoxCollider2D)
            {
                Debug.Log("Player entered the Pit's box collider trigger area!");
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (other is CapsuleCollider2D)
            {
                Debug.Log("Player exited the Pit's capsule collider trigger area.");
            }
            else if (other is BoxCollider2D)
            {
                Debug.Log("Player exited the Pit's box collider trigger area.");
            }
        }
    }*/
    void OnTriggerEnter2D(Collider2D other){
        
        //if (capsuleCollider.IsTouching(other))
        //{
            //set to destory and to add a point
            if (other.gameObject.tag == "Player"){
                Debug.Log("LOSE A LIFE");

            }
        //}
        
    }

    
}
