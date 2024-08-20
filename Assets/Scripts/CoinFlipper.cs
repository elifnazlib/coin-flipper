using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class CoinFlipper : MonoBehaviour
{
    [SerializeField] private GameObject yazi;
    [SerializeField] private GameObject tura;
    [SerializeField] private GameObject cheatPanel;
    [SerializeField] private Slider cheatSlider;
    [SerializeField] private TextMeshProUGUI infoText;
    private Random rnd;
    private int pressCount = 0;
    [SerializeField] private int yaziOrani = 50;
    void Start()
    {
        rnd = new Random();
    }

    public void Flip() {
        int num  = rnd.Next(1, 101);  // creates a number between 1 and 2
        infoText.color = new Color(
                UnityEngine.Random.Range(0f, 1f), 
                UnityEngine.Random.Range(0f, 1f), 
                UnityEngine.Random.Range(0f, 1f)
            );
        if (num <= yaziOrani) {
            Debug.Log("yazi");
            yazi.SetActive(true);
            tura.SetActive(false);
            infoText.text = "Yazı";
        } else {
            Debug.Log("tura");
            tura.SetActive(true);
            yazi.SetActive(false);
            infoText.text = "Tura";
        }
    }

    public void Reset() {
        yazi.SetActive(false);
        tura.SetActive(false);
        infoText.text = "";
    }

    public void EnterCheatPanel() {
        pressCount++;
        Debug.Log("cheat button pressed");
        if (pressCount == 7) {
            pressCount = 0;
            Reset();
            cheatPanel.SetActive(true);
        }
    }

    public void ExitCheatPanel() {
        cheatPanel.SetActive(false);
    }

    public void CheatSliderChange() {
        yaziOrani = (int) cheatSlider.value;
    }

}
