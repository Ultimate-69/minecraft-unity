using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject cameraReference;
    private Camera currentCamera;

    void Start()
    {
        currentCamera = Camera.main;
    }
    void FixedUpdate()
    {
        currentCamera.transform.position = cameraReference.transform.position;
    }
}
