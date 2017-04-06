using UnityEngine;

public class Movement : MonoBehaviour {

    public int playerNumber;
    public float speed;
    public float jumpForce;
    public int maxJumps;

    //These 4 are needed for ground checking
    bool grounded;
    public Transform groundChecker;
    public float groundCheckerRadius;
    public LayerMask whatIsGround;

    Rigidbody2D rb;
    float move;
    bool facingRight;
    bool jump;
    int jumps;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        //Listening for input. Using player numbers to avoid creating individual scripts for each player.
        move = Input.GetAxis("Horizontal" + playerNumber);
        jump = Input.GetButtonDown("Jump" + playerNumber);

        //Flipping the player depending on the direction of motion
        if (move > 0 && !facingRight) Flip();
        else if (move < 0 && facingRight) Flip();

        //It's okay to jump in Update (change velocity), because we are not adding force continiously.
        Jump();
        
    }

    void FixedUpdate() {
        //One way to check if the characters are grounded. The layer mask decides what layers count as ground.
        grounded = Physics2D.OverlapCircle(groundChecker.position, groundCheckerRadius, whatIsGround);

        

        //resets numbers of jumps when we are grounded
        if (grounded) jumps = maxJumps;

        //move left or right
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }

    void Flip() {
        //Flipping the character by inverting the x-scale.
        facingRight = !facingRight;
        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void Jump() {
        //Check if jump is pressed and we if we have any jumps left
        if (jump && jumps > 1) {
            rb.velocity = new Vector2(rb.velocity.x, 10);
            jumps -= 1;
        }
    }
}
