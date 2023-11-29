using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batInteraction : MonoBehaviour
{

    [SerializeField] GameObject[] rooms;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rooms = GameObject.FindGameObjectsWithTag("room");
        if (rooms.Length == 0)
        {
            Debug.LogError("No game objects in the array. Please assign game objects in the Unity editor.");
            return;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        
    
        //set to destory and to add a point
        if (other.gameObject.tag == "Player"){
            Debug.Log("Random roooom");
            Destroy(this.gameObject);

            GameObject room = rooms[Random.Range(0, rooms.Length)];

            // Get the position of the chosen game object
            Vector3 movePosition = room.transform.position;

            // Move the sprite to the specified position
            other.gameObject.transform.position = movePosition;

            
        }
    
        
    }
}
