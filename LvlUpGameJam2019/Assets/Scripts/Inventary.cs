using UnityEngine;
using UnityEngine.UI;

public class Inventary : MonoBehaviour {

    public Canvas inventoryCanvas;
    public Rigidbody2D rb2dPlayer;

    public Text nbCashTxt;

    public Text nbGreenTxt;
    public Text nbBlueTxt;
    public Text nbRedTxt;
    public Text nbYellowTxt;

    public Text nbRBeeTxt;
    public Text nbRBlueTxt;
    public Text nbROverkitchTxt;
    public Text nbRYellowTxt;
    public Text nbRRedTxt;
    public Text nbRGreenTxt;

    public Text nbTRBlueTxt;
    public Text nbTRYellowTxt;
    public Text nbTROrangeTxt;
    public Text nbTRPinkTxt;

    public Text nbFinalTxt;

    public int cash = 0;

    public int nbGreenFish = 0;
    public int nbBlueFish = 0;
    public int nbRedFish = 0;
    public int nbYellowFish = 0;

    public int nbRBeeFish = 0;
    public int nbRBlueFish = 0;
    public int nbROverkitchFish = 0;
    public int nbRYellowFish = 0;
    public int nbRRedFish = 0;
    public int nbRGreenFish = 0;

    public int nbTRBlueFish = 0;
    public int nbTRYellowFish = 0;
    public int nbTROrangeFish = 0;
    public int nbTRPinkFish = 0;

    public int nbFinalFish = 0;

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

                nbRBeeTxt.text = nbRBeeFish + "x";
                nbRBlueTxt.text = nbRBlueFish + "x";
                nbROverkitchTxt.text = nbROverkitchFish + "x";
                nbRYellowTxt.text = nbRYellowFish + "x";
                nbRRedTxt.text = nbRRedFish + "x";
                nbRGreenTxt.text = nbRGreenFish + "x";

                nbTRBlueTxt.text = nbTRBlueFish + "x";
                nbTRYellowTxt.text = nbTRYellowFish + "x";
                nbTROrangeTxt.text = nbTROrangeFish + "x";
                nbTRPinkTxt.text = nbTRPinkFish + "x";

                nbFinalTxt.text = nbFinalFish + "x";

                nbCashTxt.text = cash.ToString();
            }
            isOpen = !isOpen;
        }
    }
}
