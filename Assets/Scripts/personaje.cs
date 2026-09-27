using UnityEngine;

public class personaje : MonoBehaviour
{
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
        
    }
}