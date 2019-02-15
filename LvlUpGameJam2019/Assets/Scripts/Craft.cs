using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("NICE");
        }
    }
}
