using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    public Canvas shopCanvas;
    public Inventary inventary;

    // Prices
    private double[] prices;
    public double greenFishPrice;
    public double blueFishPrice;
    public double redFishPrice;
    public double yellowFishPrice;

    // Fish count number array
    int[] nbFishInventary;

    private bool isOpen = false;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if(isOpen)
            {
                // display canvas
                shopCanvas.enabled = false;
            }
            else
            {
                shopCanvas.enabled = true;
                // initialisation des affichages
            }

            Debug.Log("NICE");
        }
    }

    void sell()
    {
        double Sum = 0d;
        for(int i = 0; i < 4; i++)
        {
            Sum += prices[i] * nbFishInventary[i];
        }
        // Add money to the user
        
    }

}
