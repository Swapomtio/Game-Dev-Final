using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowShooter : MonoBehaviour
{
    
    [SerializeField] GameObject arrow;
    //[SerializeField] float shootDistance = 5f; // Distance to shoot the projectile
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
        // Get the mouse position in screen coordinates
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0; // Set the z-coordinate to 0 (assuming your game is in 2D)

        // Convert the screen coordinates to world coordinates
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Calculate the direction from the arrow shooter to the mouse position
        Vector2 shootDirection = (worldMousePosition - transform.position);

        // Calculate the rotation angle based on the shoot direction
        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;

        // Instantiate the projectile at the calculated position
        GameObject projectile = Instantiate(arrow, transform.position, Quaternion.Euler(0, 0, angle));

        // Optionally, you can add force or velocity to the projectile to make it move
        // For example, you can use Rigidbody2D component if your projectile has a Rigidbody2D attached
        Rigidbody2D arrowRb = projectile.GetComponent<Rigidbody2D>();
        if (arrowRb != null)
        {
            arrowRb.velocity = shootDirection.normalized * projectileSpeed;
            Destroy(projectile, 2); // destroy the arrow after 5 seconds
        }
        
    }
}
