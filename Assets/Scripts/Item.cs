using UnityEngine;

public class Item : MonoBehaviour
{
    public PhysicsPlayer player;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has picked up the item: " + gameObject.name);
            //Destroy(gameObject);
            player = other.GetComponent<PhysicsPlayer>();
        }
    }
}
