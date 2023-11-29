using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestInteraction : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite openChest; // Assign the new sprite in the Unity Editor
    // Start is called before the first frame update
    int heart = 1;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int giveHeart(){
        return heart;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            
        }
    }
}
