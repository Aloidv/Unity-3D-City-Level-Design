using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 60, 0); // Velocidad de rotación en grados por segundo
    void Update()
    {
        // Aplica la rotación alrededor de sus propios ejes (local)
        transform.Rotate(rotationSpeed * Time.deltaTime, Space.Self);
    }
}
