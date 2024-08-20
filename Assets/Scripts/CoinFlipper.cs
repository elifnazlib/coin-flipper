using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class CoinFlipper : MonoBehaviour
{
    [SerializeField] private GameObject yazi;
    [SerializeField] private GameObject tura;
    private Random rnd;
    void Start()
    {
        rnd = new Random();
    }

    public void Flip() {
        int num  = rnd.Next(1, 3);  // creates a number between 1 and 2

        switch (num)
        {
            case 1:
                Debug.Log("yazi");
                yazi.SetActive(true);
                tura.SetActive(false);
                break;
            case 2:
                Debug.Log("tura");
                tura.SetActive(true);
                yazi.SetActive(false);
                break;
        }
    }

}
