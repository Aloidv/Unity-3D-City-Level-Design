using TMPro;
using UnityEngine;

public class Burguer : MonoBehaviour
{
    public GameManager GameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager != null)
            {
                GameManager.Counter++;
                GameManager.CounterText.text = GameManager.Counter.ToString();
            }
            if (GameManager.Counter >= 5)
            {
                GameManager.MainCanvas.gameObject.SetActive(false);
                GameManager.WinnerCanvas.gameObject.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
