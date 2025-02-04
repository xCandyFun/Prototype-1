using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Move x times per second
    private float movePerSec = 10.0f;
    private float turnSpeed = 10.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * movePerSec * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}