using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public GameObject secondCamera;

    private bool isSecondCameraActive = false;
    private Vector3 offset = new Vector3(0, 8, -8);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        secondCamera.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Make the camera follow player
        transform.position = player.transform.position + offset;

        // if Fire1(L-ctrl) button is down
        if(Input.GetButtonDown("Fire1")) {

            isSecondCameraActive = !isSecondCameraActive; // Toggle state

            // Switch active cameras
            secondCamera.SetActive(isSecondCameraActive);
        }
    }
}
