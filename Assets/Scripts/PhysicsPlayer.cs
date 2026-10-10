using UnityEngine;

public class PhysicsPlayer : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;
    public float jumpForce = 300f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector3(moveInput * moveSpeed, rb.linearVelocity.y, rb.linearVelocity.z);

        float moveInputZ = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, moveInputZ * moveSpeed);
    }
}