using UnityEngine;

public class WeaponHit : MonoBehaviour {

    public Inventary inventary;

    void OnCollisionEnter2D(Collision2D col)
    { 
        if (col.gameObject.tag == "BlueFish")
        {
            inventary.nbBlueFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "GreenFish")
        {
            inventary.nbGreenFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "RedFish")
        {
            inventary.nbRedFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "YellowFish")
        {
            inventary.nbYellowFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "RBeeFish")
        {
            inventary.nbRBeeFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "RBlueFish")
        {
            inventary.nbRBlueFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "ROverkitchFish")
        {
            inventary.nbROverkitchFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "RYellowFish")
        {
            inventary.nbRYellowFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "RRedFish")
        {
            inventary.nbRRedFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "RGreenFish")
        {
            inventary.nbRGreenFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "TRBlueFish")
        {
            inventary.nbTRBlueFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "TRYellowFish")
        {
            inventary.nbTRYellowFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "TROrangeFish")
        {
            inventary.nbTROrangeFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "TRPinkFish")
        {
            inventary.nbTRPinkFish++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "FinalFish")
        {
            inventary.nbFinalFish++;
            Destroy(col.gameObject);
        }
    }
}
