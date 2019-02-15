using UnityEngine;

public class WeaponHit : MonoBehaviour {

    public Inventary inventary;

    void OnCollisionEnter2D(Collision2D col)
    { 
        if (col.gameObject.tag == "BlueFish")
        {
            inventary.nbBlueFish++;
        }
        else if (col.gameObject.tag == "GreenFish")
        {
            inventary.nbGreenFish++;
        }
        else if (col.gameObject.tag == "RedFish")
        {
            inventary.nbRedFish++;
        }
        else if (col.gameObject.tag == "YellowFish")
        {
            inventary.nbYellowFish++;
        }
        Destroy(col.gameObject);
    }
}
