using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreteMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 10; 
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }
    public void Movement(Vector3 vel)
    {
        transform.position += vel * speed * Time.deltaTime;
    }
    public void MoveRB(Vector3 vel)
    {
        rb.velocity = vel * speed; 
    }

}

