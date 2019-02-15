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
    }
}
