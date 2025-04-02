using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float floatStrength = 0.2f; // Intensidad del movimiento vertical
    public float floatSpeed = 1f;      // Velocidad de la oscilación

    public float tiltStrength = 5f;    // Intensidad del balanceo
    public float tiltSpeed = 1.5f;     // Velocidad del balanceo

    private Vector3 startPos;
    private Quaternion startRotation;

    void Start()
    {
        startPos = transform.position;
        startRotation = transform.rotation;
    }

    void Update()
    {
        // Movimiento de flotación
        float floatOffset = Mathf.Sin(Time.time * floatSpeed) * floatStrength;
        transform.position = startPos + new Vector3(0, floatOffset, 0);

        // Movimiento de balanceo (rotación en X e Y)
        float tiltX = Mathf.Sin(Time.time * tiltSpeed) * tiltStrength;
        float tiltZ = Mathf.Cos(Time.time * tiltSpeed) * tiltStrength;

        transform.rotation = startRotation * Quaternion.Euler(tiltX, 0, tiltZ);
    }
}
