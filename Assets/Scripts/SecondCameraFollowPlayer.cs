using UnityEngine;

public class SecondCameraFollowPlayer : MonoBehaviour
{
    public GameObject mainCamera;

    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, 0);

    private bool isSecondCameraActive = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

        if(Input.GetButtonDown("Fire1")){
            
            isSecondCameraActive = !isSecondCameraActive;

            mainCamera.SetActive(isSecondCameraActive);
        }
        
    }
}
