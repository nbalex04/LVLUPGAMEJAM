using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float onTurnVelocity = 3f;
    public float speed = 10f;
    public float top_limit;
    public float bottom_limit;

    bool isFacingRight = false;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        Vector2 movement = new Vector2(Random.Range(-1f, 1f) * speed, Random.Range(-1f, 1f) * speed);
        if (transform.position.y >= top_limit) rb2d.velocity = new Vector2(0, -2);
        else if (transform.position.y <= bottom_limit) rb2d.velocity = new Vector2(0, 2);

        rb2d.AddForce(movement);

        if (rb2d.velocity.x > 0 && !isFacingRight)
        {
            Flip();
            rb2d.velocity = new Vector2(onTurnVelocity, rb2d.velocity.y);
        }
        else if (rb2d.velocity.x < 0 && isFacingRight)
        {
            Flip();
            rb2d.velocity = new Vector2(-onTurnVelocity, rb2d.velocity.y);
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
