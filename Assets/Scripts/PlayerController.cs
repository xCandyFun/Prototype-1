using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Move x times per second
    public float movePerSec = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * movePerSec);
    }
}