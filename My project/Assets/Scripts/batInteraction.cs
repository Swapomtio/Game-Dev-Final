using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batInteraction : MonoBehaviour
{

    [SerializeField] GameObject[] randomGameObjects;
    [SerializeField] GameObject spriteToMove;
    
    // Start is called before the first frame update
    void Start()
    {

        if (randomGameObjects.Length == 0)
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

            GameObject randomGameObject = randomGameObjects[Random.Range(0, randomGameObjects.Length)];

            // Get the position of the chosen game object
            Vector3 movePosition = randomGameObject.transform.position;

            
            if (spriteToMove == null)
            {
                Debug.LogError("No sprite assigned. Please assign the sprite to move in the Unity editor.");
                return;
            }

            // Move the sprite to the specified position
            spriteToMove.transform.position = movePosition;

            // Optionally, you can perform additional operations on the moved sprite
            // For example, you might want to set its parent to the chosen game object
            spriteToMove.transform.SetParent(randomGameObjects[Random.Range(0, randomGameObjects.Length)].transform);

            // You can also add any other logic or components to the spawned sprite as needed
        }
        
    }
}
