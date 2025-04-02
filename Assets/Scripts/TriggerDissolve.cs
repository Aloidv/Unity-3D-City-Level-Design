using UnityEngine;

public class TriggerDissolve : MonoBehaviour
{
    public Animator ColaAnimator;

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entra en el trigger tiene un tag espec�fico
        if (other.CompareTag("Player"))
        {
            // Activa la animaci�n
            if (ColaAnimator != null)
                ColaAnimator.SetBool("IsDissolving",true);
        }
    }
}
