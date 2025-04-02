using UnityEngine;

public class TriggerShortcut : MonoBehaviour
{
    public GameObject objectToActivate;  
    public GameObject objectToDeactivate;  

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entra en el trigger tiene un tag específico, si lo deseas
        if (other.CompareTag("Player")) // Cambia "Player" por el tag que prefieras
        {
            // Activa y desactiva los objetos
            if (objectToActivate != null)
                objectToActivate.SetActive(true);
            if (objectToDeactivate != null)
                objectToDeactivate.SetActive(false);
        }
    }
}
