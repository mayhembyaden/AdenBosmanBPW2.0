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

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

        }
        if (Input.GetKey(right))
        {
            vel += transform.right * moveSpeed;
        }
        rb.velocity = new Vector2(vel.x, rb.velocity.y);

    }

}
