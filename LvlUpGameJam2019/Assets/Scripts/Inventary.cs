using UnityEngine;
using UnityEngine.UI;

public class Inventary : MonoBehaviour {

    public Canvas inventoryCanvas;
    public Rigidbody2D rb2dPlayer;
    public Text nbGreenTxt;
    public Text nbBlueTxt;
    public Text nbRedTxt;
    public Text nbYellowTxt;

    public int cash = 0;
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
                rb2dPlayer.constraints = RigidbodyConstraints2D.FreezeRotation;
                inventoryCanvas.enabled = false;
            } else
            {
                rb2dPlayer.constraints = RigidbodyConstraints2D.FreezePosition;
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
