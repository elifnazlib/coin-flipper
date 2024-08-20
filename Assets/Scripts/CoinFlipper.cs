using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class CoinFlipper : MonoBehaviour
{
    [SerializeField] private GameObject yazi;
    [SerializeField] private GameObject tura;
    [SerializeField] private GameObject cheatPanel;
    [SerializeField] private Slider cheatSlider;
    private Random rnd;
    private int pressCount = 0;
    [SerializeField] private int yaziOrani = 50;
    void Start()
    {
        rnd = new Random();
    }

    public void Flip() {
        int num  = rnd.Next(1, 101);  // creates a number between 1 and 2

        if (num < yaziOrani) {
            Debug.Log("yazi");
            yazi.SetActive(true);
            tura.SetActive(false);
        } else {
            Debug.Log("tura");
            tura.SetActive(true);
            yazi.SetActive(false);
        }
    }

    public void CheatFlip() {
        pressCount++;
        Debug.Log("cheat button pressed");
        if (pressCount == 7) {
            pressCount = 0;
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
