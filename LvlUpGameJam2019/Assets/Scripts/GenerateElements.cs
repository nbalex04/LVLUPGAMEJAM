using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateElements : MonoBehaviour {

    public Transform player;

    public GameObject fish_green;
    public GameObject fish_blue;
    public GameObject fish_red;
    public GameObject fish_yellow;

    void Start () {

        // First step (1-30)
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_green,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-1f, -30f)),
            Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_blue,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-1f, -30f)),
            Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_red,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-1f, -30f)),
            Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_yellow,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-1f, -30f)),
            Quaternion.identity) as GameObject;
        }

        // Second step (31-60)
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_green,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-31f, -60f)),
            Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_blue,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-31f, -60f)),
            Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_red,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-31f, -60f)),
            Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_yellow,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-31f, -60f)),
            Quaternion.identity) as GameObject;
        }

        // Second step (61-90)
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_green,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-61f, -90f)),
            Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_blue,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-61f, -90f)),
            Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_red,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-61f, -90f)),
            Quaternion.identity) as GameObject;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_yellow,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-61f, -90f)),
            Quaternion.identity) as GameObject;
        }
    }
	
	void Update () {
		
	}
}
