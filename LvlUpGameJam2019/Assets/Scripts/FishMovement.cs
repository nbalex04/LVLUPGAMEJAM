using UnityEngine;

public class FishMovement : MonoBehaviour {

    public float speed = 10f;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	void Update () {
        Vector2 movement = new Vector2(Random.Range(-1f, 1f) * speed, Random.Range(-1f, 1f) * speed);
        rb2d.AddForce(movement);
    }
}
