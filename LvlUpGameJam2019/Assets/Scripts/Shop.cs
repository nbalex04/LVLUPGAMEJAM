using UnityEngine;

public class Shop : MonoBehaviour {

    public Collider2D playerCol;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("ENTER IN SHOP");
        }
    }
}
