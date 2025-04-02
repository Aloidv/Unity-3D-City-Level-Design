using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Counter;
    public TextMeshProUGUI CounterText;
    public Canvas WinnerCanvas;
    public Canvas MainCanvas;

    void Start()
    {
        Counter = 0;
    }
}
