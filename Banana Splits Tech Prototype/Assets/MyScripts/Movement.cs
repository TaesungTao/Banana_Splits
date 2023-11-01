using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private CircleCollider2D circleCollider2D;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
   // [Range(0, 100f)] [SerializeField] private float speed = 50f;
 
    float horizontal = 0f;
    float vertical = 0f;
    private bool isFacingRight = true;
    bool jump = false, jumpHeld = false;
    public int doubleJump = 0;
    bool wallJump = false;
    bool dash = false;
    bool climb = false;
    public float dashSpeed = 15f;
    public float climbSpeed = 15f;
    public Animator anim;
 
    [Range(0, 10f)] [SerializeField] private float fallLongMult = 0.85f;
    [Range(0, 10f)] [SerializeField] private float fallShortMult = 1.55f;
 
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        circleCollider2D = GetComponent<CircleCollider2D>();
        anim = GetComponent<Animator>();
    }
 
    void Update()
{
    // horizontal movement 
    horizontal = Input.GetAxisRaw("Horizontal") * Manager.Instance.Speed;
    anim.SetFloat("speed", Mathf.Abs(horizontal));
    vertical = Input.GetAxisRaw("Vertical") * Manager.Instance.Speed;
    //jump detectors
    if (isOnGround())
    {
        doubleJump = 0;
        
        anim.SetBool("isJumping", false);
    }
    else
    {
        anim.SetBool("isJumping", true);
    }
    if (isOnWall())
    {
        if (Manager.Instance.DoubleJumpUp >= 1)
        {
            doubleJump = 0;
        }
        anim.SetBool("isClinging", true);

    }
    else
    {
        anim.SetBool("isClinging", false);
    }
    if (Input.GetButtonDown("Jump")) {
        if (doubleJump <1 && Manager.Instance.DoubleJumpUp >= 1)
        {
        jump = true;
        }
        if (isOnGround() && Manager.Instance.DoubleJumpUp == 0)
        {
            jump = true;
        }
    }
    jumpHeld = (!isOnGround() && Input.GetButton("Jump")) ? true : false; 

    if (Input.GetKeyDown(KeyCode.LeftShift)) {
        dash = true;
        anim.SetBool("isDashing", true);

}
if (Input.GetKeyUp(KeyCode.LeftShift)){
    dash = false;
    anim.SetBool("isDashing", false);
}
if (Input.GetKeyDown(KeyCode.W) && Manager.Instance.WallUp >= 1 && isOnWall()){
    climb = true;
}
if (Input.GetKeyUp(KeyCode.W)){
    climb = false;
}
if (!isOnWall())
{
    climb = false;
}
}
 
void FixedUpdate()
{
    float moveFactor = horizontal * Time.fixedDeltaTime;
    float vertFactor = vertical * Time.fixedDeltaTime;

    if (!dash){
        dashSpeed = 15f;
    }
    else {
        dashSpeed = 20f;
    }
    if (climb){
    rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, vertFactor * climbSpeed);
    }
 
    // Movement...
    rigidBody2D.velocity = new Vector2(moveFactor * dashSpeed, rigidBody2D.velocity.y);
    //Flip the sprite 
    if (moveFactor > 0 && !isFacingRight) flipSprite();
    else if (moveFactor < 0 && isFacingRight) flipSprite();
     // Jumping...
     if (jump)
    {
        float jumpvel = 17f;
        rigidBody2D.velocity = Vector2.up * jumpvel;
        jump = false;
        doubleJump++;
    }
    // Jumping High...
    if(jumpHeld && rigidBody2D.velocity.y > 0)
    {
        rigidBody2D.velocity += Vector2.up * Physics2D.gravity.y * (fallLongMult - 2) * Time.fixedDeltaTime;
    }
    // Jumping Low...
    else if(!jumpHeld && rigidBody2D.velocity.y > 0)
    {
        rigidBody2D.velocity += Vector2.up * Physics2D.gravity.y * (fallShortMult - 2) * Time.fixedDeltaTime;
    }

}
private void flipSprite()
{
    isFacingRight = !isFacingRight;
 
    Vector3 transformScale = transform.localScale;
    transformScale.x *= -1;
    transform.localScale = transformScale;
}
private bool isOnGround()
{
    RaycastHit2D hit = Physics2D.CircleCast(circleCollider2D.bounds.center, circleCollider2D.radius, Vector2.down, 0.0f, groundLayer);
    return hit.collider !=null;
}
private bool isOnWall()
{
    RaycastHit2D hit = Physics2D.CircleCast(circleCollider2D.bounds.center, circleCollider2D.radius, Vector2.right, 0.0f, wallLayer);
    return hit.collider !=null;
}
}