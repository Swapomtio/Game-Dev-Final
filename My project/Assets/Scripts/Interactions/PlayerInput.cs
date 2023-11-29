using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    
    //variable 
    int arrowNum;
    [SerializeField] Text arrowText; 
    ArrowShooter shooter;

    // movement
    DiscreteMovement move;
    [SerializeField] Transform target;  //The game object to follow
    [SerializeField] float smoothSpeed = 0.125f;  //The smoothness of the camera movement
    
    //map
    int mapOpen;
    SpriteRenderer playerSpriteRenderer;
    [SerializeField] Text minimapTitle; 
    [SerializeField] Image minimapImage;
    [SerializeField] GameObject player;


    void Awake(){
        move = GetComponent<DiscreteMovement>();
        shooter = GetComponent<ArrowShooter>();
        playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
        arrowNum = 3;
        mapOpen = 1;
        minimapTitle.enabled = false;
        minimapImage.enabled = false;
        playerSpriteRenderer.enabled = false;
        arrowText.text = arrowNum.ToString() + " x";
    }
    //Update is called once per frame
    void Update()
    {
        // movement
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
        
        move.MoveRB(vel);

        // arrow
        if (Input.GetKeyDown(KeyCode.Q)){
            Debug.Log("Arrow");
            Debug.Log(arrowNum);
            //arrowNum = int.Parse(arrowText.text);

            if (arrowNum > 0){
                arrowNum -= 1;
                shooter.Shoot();
                arrowText.text = arrowNum.ToString() + " x";
            }
            if (arrowNum <= 0){
                arrowNum = 0;
                Debug.Log(arrowNum);
                arrowText.text = arrowNum.ToString() + " x";
                Debug.Log("Game Over");
                //SceneManager.LoadScene("YouLose");
            }
            
        }

        //minimap
        if (Input.GetKeyDown(KeyCode.M)){
            Debug.Log("map code");
            if(mapOpen == 1){
                Debug.Log("Open map");
                minimapTitle.enabled = true;
                minimapImage.enabled = true;
                playerSpriteRenderer.enabled = true;
                mapOpen = 0;
            }
            else if(mapOpen == 0){
                Debug.Log("Close map");
                minimapTitle.enabled = false;
                minimapImage.enabled = false;
                playerSpriteRenderer.enabled = false;
                mapOpen = 1;
            }
        }
        
        
        
    }
    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
    
    void OnTriggerEnter2D(Collider2D other){
        
        if (other.gameObject.tag == "arrow_drop"){
            arrowNum += 1;
            arrowText.text = arrowNum.ToString() + " x";
            Destroy(other.gameObject);
            Debug.Log("get an arrow");
        }
    }
}
