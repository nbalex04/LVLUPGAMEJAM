using UnityEngine;
using UnityEngine.UI;

public class Inventary : MonoBehaviour {

    public Canvas inventoryCanvas;
    public Text nbGreenTxt;
    public Text nbBlueTxt;
    public Text nbRedTxt;
    public Text nbYellowTxt;

    public int nbGreenFish = 0;
    public int nbBlueFish = 0;
    public int nbRedFish = 0;
    public int nbYellowFish = 0;

    private bool isOpen = false;

    void Update()
    {
        if (Input.GetButtonDown("Menu"))
        {
            if (isOpen)
            {
                inventoryCanvas.enabled = false;
            } else
            {
                inventoryCanvas.enabled = true;
                nbGreenTxt.text = nbGreenFish + "x";
                nbBlueTxt.text = nbBlueFish + "x";
                nbRedTxt.text = nbRedFish + "x";
                nbYellowTxt.text = nbYellowFish + "x";
            }
            isOpen = !isOpen;
        }
    }
}
