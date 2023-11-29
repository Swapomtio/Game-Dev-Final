using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerStatusUpdater : MonoBehaviour
{
    int health; 
    [SerializeField] Sprite heartSprite;
    [SerializeField] Sprite emptyHeartSprite;
    [SerializeField] Image heartOne;
    [SerializeField] Image heartTwo;
    [SerializeField] Image heartThree;

    
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(health >= 3){
            heartOne.sprite = heartSprite;
            heartTwo.sprite = heartSprite;
            heartThree.sprite = heartSprite;
            health = 3;
        }
        if(health == 2){
            heartOne.sprite = heartSprite;
            heartTwo.sprite = heartSprite;
            heartThree.sprite = emptyHeartSprite;
        }
        if(health == 1){
            heartOne.sprite = heartSprite;
            heartTwo.sprite = emptyHeartSprite;
            heartThree.sprite = emptyHeartSprite;  
        }
        if(health <= 0){
            heartOne.sprite = emptyHeartSprite;
            heartTwo.sprite = emptyHeartSprite;
            heartThree.sprite = emptyHeartSprite;  
            health = 0;  
            Debug.Log("Game Over");
            //SceneManager.LoadScene("YouLose");
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        

        //set to destory and to add a point
        if (other.gameObject.tag == "pit"){
            health -= 1;
            Debug.Log("Stepping on pit");
        }

        if (other.gameObject.tag == "wumpus"){
            health = 0;
            Debug.Log("Stepping on wumpus");
        }

        if (other.gameObject.tag == "heart"){
            health += 1;
            Destroy(other.gameObject);
            Debug.Log("get a heart");
        }
        
        Debug.Log("Health is " + health);
        
    }
}
