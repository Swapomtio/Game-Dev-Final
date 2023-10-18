using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{

    //variable 
    [SerializeField] Text arrowNum;
    DiscreteMovement move;
    ArrowShooter shooter;
    int currNum = 1;
    

    void Awake(){
        move = GetComponent<DiscreteMovement>();
        shooter = GetComponent<ArrowShooter>();
        //arrowNum.text = currNum.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 vel = Vector3.zero; //dont include the new with static vectors 
        
        if (Input.GetKey(KeyCode.A)){
            vel.x = -1;
            //Debug.Log("A");
        }
        if (Input.GetKey(KeyCode.D)){
            //Debug.Log("D");
            vel.x = 1;
        }
        if (Input.GetKey(KeyCode.W)){
            //Debug.Log("W");
            vel.y = 1;
        }
        if (Input.GetKey(KeyCode.S)){
            //Debug.Log("S");
            vel.y = -1;
        }
        //move.Movement(vel);
        move.MoveRB(vel);

        if (Input.GetKeyDown(KeyCode.Q)){
            Debug.Log("Arrow");
            Debug.Log(arrowNum.text);
            currNum = int.Parse(arrowNum.text);
            if (currNum > 0){
                shooter.Shoot();
                currNum = 0;
                Debug.Log(currNum);
                arrowNum.text = currNum.ToString();
                
            }
            else{
                Debug.Log("Game Over");
                SceneManager.LoadScene("YouLose");
            }
            
        }
        
    }
}
