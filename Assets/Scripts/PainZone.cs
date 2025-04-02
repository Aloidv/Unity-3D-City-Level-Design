using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class PainZone : MonoBehaviour
{
    public PostProcessVolume mainCameraVolume; // Referencia al volumen de la cámara principal
    public PostProcessProfile defaultProfile;  // Perfil que quieres activar al entrar en el trigger
    public PostProcessProfile dangerProfile; // Almacena el perfil original

    private void Start()
    {
        // Almacena el perfil original de la cámara
        if (mainCameraVolume != null)
        {
            defaultProfile = mainCameraVolume.profile;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si la cámara entró en el trigger
        if (other.CompareTag("MainCamera") && mainCameraVolume != null)
        {
            mainCameraVolume.profile = defaultProfile; // Cambia al nuevo perfil
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Restablece el perfil original al salir del trigger
        if (other.CompareTag("MainCamera") && mainCameraVolume != null)
        {
            mainCameraVolume.profile = defaultProfile;
        }
}
}
