using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    private float rotationSpeed = 60.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed);
    }
}
