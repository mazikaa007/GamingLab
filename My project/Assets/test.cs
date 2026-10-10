using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Animator anim;



    public float moveSpeed;
    public float jumpHeight;
    
    public KeyCode R;
    public KeyCode L;

    public KeyCode Spacebar;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private bool grounded;
    void Start()
    {
      anim =GetComponent<Animator>();
       if (Input.GetKey(L)) {

        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if(GetComponent<SpriteRenderer>() != null)
{
    GetComponent<SpriteRenderer>().flipX = true;
      }      }
        if(Input.GetKey(R)) {

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if(GetComponent<SpriteRenderer>() != null)
{
        GetComponent<SpriteRenderer>().flipX = false;
   }}   }

   

        void Update () {

        if(Input.GetKeyDown(Spacebar) && grounded)
    {
    Jump(); 
    }
    if (Input.GetKey(L)) {

            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }
        if(Input.GetKey(R)) 
            {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            }
    
            anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
            anim.SetFloat("Height", GetComponent<Rigidbody2D>().velocity.y);
            anim.SetBool("Ground", grounded);
        }


        void FixedUpdate(){

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        }
            
            void Jump(){

GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
}
}