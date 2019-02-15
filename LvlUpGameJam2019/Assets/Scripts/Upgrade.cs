using UnityEngine;

public class Upgrade : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("ENTER IN UPGRADE");
        }
    }
}
