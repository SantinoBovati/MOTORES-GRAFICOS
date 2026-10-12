using System.Runtime.CompilerServices;
using UnityEngine;

public class PhysicsPlayer : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;
    public float jumpForce = 300f;
    public int itemcollected = 0;
    public Transform cameraTransform;

    private bool isGrounded;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isGrounded = false;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 10f;
        }
        else
        {
            moveSpeed = 5f;
        }
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        if (cameraTransform == null && Camera.main != null)
        {
            cameraTransform = Camera.main.transform;
        }

        Vector3 moveDir = Vector3.zero;

        if (cameraTransform != null)
        {
            Vector3 camForward = cameraTransform.forward;
            Vector3 camRight = cameraTransform.right;

            camForward.y = 0f;
            camRight.y = 0f;
            camForward.Normalize();
            camRight.Normalize();

            moveDir = (camForward * moveZ + camRight * moveX).normalized;
        }
        else
        {
            moveDir = new Vector3(moveX, 0, moveZ).normalized;
        }

        rb.linearVelocity = new Vector3(moveDir.x * moveSpeed, rb.linearVelocity.y, moveDir.z * moveSpeed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("ProBuilderObjects"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("ProBuilderObjects"))
        {
            isGrounded = false;
        }
    }

    public void CollectItem()
    {
        itemcollected++;
        Debug.Log("Items collected: " + itemcollected);
    }
}
