using UnityEngine;

public class personaje : MonoBehaviour
{
    public CharacterController Charactercontroller;
    public Vector3 StartPosition;
    public int Counter = 0;
    public float Speed = 5f;
    void Start()
    {
        Debug.Log("Arranca el PJ a funcionar");
        transform.position = StartPosition;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Charactercontroller.Move(new Vector3(0, 0, 1) * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Charactercontroller.Move(new Vector3(0, 0, -1) * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(new Vector3(-1, 0, 0) * Speed * Time.deltaTime);
            Charactercontroller.Move(new Vector3(-1, 0, 0) * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(new Vector3(1, 0, 0) * Speed * Time.deltaTime);
            Charactercontroller.Move(new Vector3(1, 0, 0) * Speed * Time.deltaTime);
        }
    }
}