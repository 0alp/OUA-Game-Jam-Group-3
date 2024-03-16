using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement2D : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float speed;
    [SerializeField] float jumpPower;

    private bool isFacingRight;
    private Vector2 movementInput;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Run();

    }

    void FlipSprite()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.y);


    }

    void Run()
    {
        rb.velocity = new Vector2(movementInput.x, rb.velocity.y);

    }

    void OnMove(InputValue input) 
    {
        movementInput.x = input.Get<Vector2>().x;
        


    }

   
}
