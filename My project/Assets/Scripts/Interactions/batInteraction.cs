using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batInteraction : MonoBehaviour
{

    [SerializeField] GameObject[] rooms;
    SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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

    void OnTriggerEnter2D(Collider2D other)
    {
        // Set to destroy and to add a point
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Random room");
            spriteRenderer.enabled = true;
            StartCoroutine(WaitAndExecuteNextCommand(other));
        }
    }

    private IEnumerator WaitAndExecuteNextCommand(Collider2D other)
    {
        yield return new WaitForSeconds(1f);

        // Your next command goes here
        Debug.Log("Next command after 1 seconds");

        // Example: Load a new scene
        // SceneManager.LoadScene("NextScene");

        // Move the sprite to a random room after waiting
        GameObject room = rooms[Random.Range(0, rooms.Length)];
        Vector3 movePosition = room.transform.position;
        // Move the sprite to the specified position
        // Assuming 'other' refers to the player GameObject
        other.transform.position = movePosition;

        // Destroy the current game object
        Destroy(gameObject);
    }
}
