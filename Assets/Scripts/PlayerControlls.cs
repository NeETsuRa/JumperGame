using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlls : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpStrenght;
    public Transform groundCheck;
    public Transform groundCheckBack;
    public float groundCheckRaduius;
    public LayerMask whatIsGround;
    private bool onGround;
    private int speed = 2;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRaduius, whatIsGround) ||
            Physics2D.OverlapCircle(groundCheckBack.position, groundCheckRaduius, whatIsGround);

        if (Input.GetMouseButtonDown(0) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpStrenght);
        }

        if (rb.position.y < -10)
        {
            lostLife();
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        rb.rotation = 0;
    }

    void lostLife()
    {
        rb.MovePosition(new Vector2(0,0));
    }
}
