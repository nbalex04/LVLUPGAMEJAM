using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float bouncingLimitLowHigh = 5f;
    public float bouncingHigh = 2f;
    public float bouncingLow = 0.5f;
    public float speed = 40f;
    public float velocityMax = 10f;

    private Rigidbody2D rb2d;
    bool isFacingRight = true;
    bool isBouncing = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveVertical < 0) moveVertical = 0;

        if (rb2d.velocity.x <= -velocityMax)
        {
            if (moveHorizontal < 0) moveHorizontal = 0;
        }
        else if (rb2d.velocity.x >= velocityMax)
        {
            if (moveHorizontal > 0) moveHorizontal = 0;
        }

        if (rb2d.velocity.y <= -velocityMax)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, -velocityMax);
            if (moveVertical < 0) moveVertical = 0;
        }
        else if (rb2d.velocity.y >= velocityMax)
        {
            moveVertical = 0;
        }

        if (transform.position.y >= 0 && !isBouncing)
        {
            isBouncing = true;
            moveVertical = 0;
            if (rb2d.velocity.y > bouncingLimitLowHigh) rb2d.velocity = new Vector2(rb2d.velocity.x, bouncingHigh);
            else rb2d.velocity = new Vector2(rb2d.velocity.x, bouncingLow);
        }
        else if (transform.position.y >= 0 && isBouncing)
        {
            moveVertical = 0;
        }
        else if (transform.position.y <= 0 && isBouncing)
        {
            isBouncing = false;
        }

        Vector2 movement = new Vector2(moveHorizontal * speed / 4, moveVertical * speed);

        rb2d.AddForce(movement);

        if ((moveHorizontal > 0 && !isFacingRight) || (moveHorizontal < 0 && isFacingRight))
        {
            Flip();
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
