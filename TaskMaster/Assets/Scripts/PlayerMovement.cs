using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float initialMoveSpeed = 5f;

    private float moveSpeed = 5f;
    
    public Rigidbody2D playerBody;
    
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = initialMoveSpeed * 2;
        }
        else
        {
            moveSpeed = initialMoveSpeed;
        }
    }

    private void FixedUpdate()
    {
        playerBody.MovePosition(playerBody.position + movement * moveSpeed * Time.deltaTime);
    }
}
