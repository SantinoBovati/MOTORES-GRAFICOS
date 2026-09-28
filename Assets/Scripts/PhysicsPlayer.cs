using UnityEngine;

public class PhysicsPlayer : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 ForceDirection;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 20, 0));
        }
    }
}
