using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 100f;
    public float distanceFromPlayer = 4f;
    public float height = 1.5f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        if (player == null) return;

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationX += mouseX;
        rotationY -= mouseY;
        rotationY = Mathf.Clamp(rotationY, -15f, 60f);

        player.rotation = Quaternion.Euler(0, rotationX, 0);

        Quaternion rotation = Quaternion.Euler(rotationY, rotationX, 0);
        Vector3 targetPosition = player.position - (rotation * Vector3.forward * distanceFromPlayer) + (Vector3.up * height);

        transform.position = targetPosition;
        transform.LookAt(player.position + Vector3.up * height);
    }
}