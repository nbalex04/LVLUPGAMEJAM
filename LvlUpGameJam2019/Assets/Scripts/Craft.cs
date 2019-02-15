using UnityEngine;

public class Craft : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("ENTER IN CRAFT");
        }
    }
}
