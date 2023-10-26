using UnityEngine;

public class StopObject : MonoBehaviour
{
    private Rigidbody2D rb; // Assuming you are using a Rigidbody2D, change it if you're using a different Rigidbody type.
    public float stopForce = 10.0f; // The force to stop the object.

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!Input.GetMouseButton(0))
        {
            StopMovement();
        }
    }

    private void StopMovement()
    {
        // Calculate the force needed to stop the object's movement.
        Vector2 oppositeForce = -rb.velocity * stopForce;

        // Apply the force to stop the object.
        rb.AddForce(oppositeForce);
    }
}

