using UnityEngine;

public class TriggerDissolve : MonoBehaviour
{
    public Animator ColaAnimator;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entra en el trigger tiene un tag específico
        if (other.CompareTag("Player"))
        {
            // Activa la animación
            if (ColaAnimator != null)
                ColaAnimator.SetBool("IsDissolving",true);
        }
    }
}
