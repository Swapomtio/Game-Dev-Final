using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowShooter : MonoBehaviour
{
    [SerializeField] Text arrowNum; 
    [SerializeField] GameObject arrow;
    [SerializeField] float shootDistance = 5f; // Distance to shoot the projectile
    [SerializeField] Vector2 shootDirection = Vector2.left; // Direction to shoot the projectile
    [SerializeField] float projectileSpeed = 10f; // Speed of the projectile

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(){
        // Calculate the position to spawn the projectile based on the shoot distance and direction
        //Vector2 spawnPosition = (Vector2)transform.position + shootDirection.normalized * shootDistance;

        // Instantiate the projectile at the calculated position
        GameObject projectile = Instantiate(arrow, transform.position, arrow.transform.rotation);

        // Optionally, you can add force or velocity to the projectile to make it move
        // For example, you can use Rigidbody2D component if your projectile has a Rigidbody2D attached
        Rigidbody2D arrowRb = projectile.GetComponent<Rigidbody2D>();
        if (arrowRb != null)
        {
            arrowRb.velocity = shootDirection.normalized * projectileSpeed;
        }
    }
}
