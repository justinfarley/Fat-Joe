using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb2d;

    Animator animator;

    [Header("Background Variables")]
    public float speed = 0.6f;
    public float maxSpeed = 0.6f;
    public float jumpStrength = 5f;
    public float friction = 2.5f;
    public JoeStats joe;
    public BoxCollider2D joeBox;
    public bool isGrounded = false;
    [SerializeField] private LayerMask platformLayerMask;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    private bool IsGrounded()
    {
        float extraHeightTest = 0.1f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(joeBox.bounds.center, joeBox.bounds.size, 0, Vector2.down, extraHeightTest, platformLayerMask);
        return raycastHit.collider != null;
    }

    private void LateUpdate()
    {
        
        if (rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
        else if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }

        if (Input.GetAxisRaw("Horizontal") != 0.0f)
        {
            
            rb2d.AddForce(speed * Vector2.right * Input.GetAxisRaw("Horizontal"), ForceMode2D.Impulse);
            
        }
        else
        {
            
            rb2d.velocity = Vector2.Lerp(rb2d.velocity, new Vector2(0.0f, rb2d.velocity.y), friction);
        }
        if (joe.semifat == false && Input.GetAxisRaw("Horizontal") > 0)
        {
            animator.SetBool("RunningLeft", false);
            animator.SetBool("RunningRight", true);
        }
        else if(joe.semifat == false && Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.SetBool("RunningRight", false);
            animator.SetBool("RunningLeft", true);
        }
        else if(joe.semifat == false && Input.GetAxisRaw("Horizontal") == 0)
        {
            animator.SetBool("RunningRight", false);
            animator.SetBool("RunningLeft", false);
        }
        if(IsGrounded() == false)
        {
            animator.SetBool("Jumping", true);
        }
        else if(IsGrounded() == true)
        {
            animator.SetBool("Jumping", false);
        }

        if (IsGrounded() == false && joe.semifat == true)
        {
            animator.SetBool("semifatJumping", true);
        }
        else if (IsGrounded() == true && joe.semifat == true)
        {
            animator.SetBool("semifatJumping", false);
        }
        if (IsGrounded() == false && joe.halffat == true)
        {
            animator.SetBool("halfFatJumping", true);
        }
        else if (IsGrounded() == true && joe.halffat == true)
        {
            animator.SetBool("halfFatJumping", false);
        }
        if (IsGrounded() == false && joe.fat == true)
        {
            animator.SetBool("FatJumping", true);
        }
        else if (IsGrounded() == true && joe.fat == true)
        {
            animator.SetBool("FatJumping", false);
        }

        if (joe.semifat == false && Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpStrength);   
        }
        else if(joe.semifat == true && Input.GetButtonDown("Jump") && IsGrounded())
        {
            
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpStrength);
            
        }
        
    }
}
