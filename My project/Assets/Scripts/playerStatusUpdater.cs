using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerStatusUpdater : MonoBehaviour
{
    [SerializeField] Text healthText;
    [SerializeField] Text prompt;
    int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        

        //set to destory and to add a point
        if (other.gameObject.tag == "pit"){
            health -= 1;
            if(health <= 0){
                health = 0;
                healthText.text = health.ToString();    
                Debug.Log("Game Over");
                SceneManager.LoadScene("YouLose");
            }
            
            healthText.text = health.ToString();
        }

        if (other.gameObject.tag == "wumpus"){
            health = 0;
            healthText.text = health.ToString();
            Debug.Log("Game Over");
            SceneManager.LoadScene("YouLose");
        }
    }
}
