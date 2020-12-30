using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 position;
    public Vector2 movement;
    public float movementSpeed = 5f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        position = new Vector2(4.28f, 1.28f);
    }

    // Update is called once per frame
    void Update()
    {
        //Up and Down inputs (W and S)
        movement.y = Input.GetAxisRaw("Vertical");

        //Left and Right inputs (A and D)
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    //Fixed Update called 50 times a second
    private void FixedUpdate()
    {
        //Movement for the player
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}