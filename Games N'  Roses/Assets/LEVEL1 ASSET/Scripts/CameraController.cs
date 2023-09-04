using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
        
    public float smoothSpeed = 0.5f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }




}
