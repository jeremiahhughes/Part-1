using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{

    public Vector2 initialForce = new Vector2(0, 5f);
    public float bounceStrength = 5f;  // The strength of the bounce
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ApplyInitialForce();
    }

    void ApplyInitialForce()
    {
        rb.AddForce(initialForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Calculate the bounce force as a vector pointing upwards
        Vector2 bounceForce = Vector2.up * bounceStrength;

        // Apply the bounce force
        rb.AddForce(bounceForce, ForceMode2D.Impulse);
    }
}
