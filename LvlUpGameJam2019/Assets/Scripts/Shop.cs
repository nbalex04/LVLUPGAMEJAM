using UnityEngine;

public class Shop : MonoBehaviour
{

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
    public Collider2D playerCol;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (isOpen)
            {
                // display canvas
                shopCanvas.enabled = false;
            }
            else
            {
                shopCanvas.enabled = true;
                // initialisation des affichages
            }

            Debug.Log("ENTER IN SHOP");
        }
    }

    void sell()
    {
        double Sum = 0d;
        for (int i = 0; i < 4; i++)
        {
            Sum += prices[i] * nbFishInventary[i];
        }
        // Add money to the user

    }

}
