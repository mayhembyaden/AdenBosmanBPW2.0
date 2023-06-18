using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement Instance { get; private set; }

    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;

    public float moveSpeed;

    Rigidbody2D rb;

    Animator animator;

    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        Vector3 vel = Vector3.zero;
    
        if (Input.GetKey(left))
        {
            vel -= transform.right * moveSpeed;
            spriteRenderer.flipX = false;

        }
        if (Input.GetKey(right))
        {
            vel += transform.right * moveSpeed;
            spriteRenderer.flipX = true;
        }
        rb.velocity = new Vector2(vel.x, rb.velocity.y);

        bool moving = vel!= Vector3.zero;
        animator.SetBool("Moving", moving);

    }

}
