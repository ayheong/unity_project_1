using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float initialMoveSpeed = 5f;

    private float moveSpeed;
    
    public Rigidbody2D playerBody;

    public Animator animator;

    private float last_direction_x;
    private float last_direction_y;
    
    Vector2 movement;
    private void Start()
    {
        moveSpeed = initialMoveSpeed;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(movement.x > 0.01)
        {
            animator.SetFloat("Last_Direction_X", 1);
            animator.SetFloat("Last_Direction_Y", 0);
        }
        else if(movement.x < -0.01)
        {
            animator.SetFloat("Last_Direction_X", -1);
            animator.SetFloat("Last_Direction_Y", 0);
        }


        if(movement.y > 0.01)
        {
            animator.SetFloat("Last_Direction_Y", 1);
            animator.SetFloat("Last_Direction_X", 0);
        }
        else if (movement.y < -0.01)
        {
            animator.SetFloat("Last_Direction_Y", -1);
            animator.SetFloat("Last_Direction_X", 0);
        }

        if (Input.GetKey(KeyCode.LeftShift))
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
