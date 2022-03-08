using UnityEngine;

public class Background : MonoBehaviour
{
    public float shiftDistance = 10.5f;
    private Camera _mainCamera;
    void Start()
    {
        _mainCamera = FindObjectOfType<Camera>();
    }

    void Update()
    {
        Vector3 transformPosition = transform.position;
        if(transformPosition.y - _mainCamera.transform.position.y <= shiftDistance)
        {
            transformPosition.y = _mainCamera.transform.position.y;
        }
        transform.position = transformPosition;
    }
}
