using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateElements : MonoBehaviour {

    public Transform player;

    public GameObject fish_green;
    public GameObject fish_blue;
    public GameObject fish_red;
    public GameObject fish_yellow;

    public float firstStep = 30;
    public float secondStep = 60;
    public float thirdStep = 90;

    void Start () {

        // First step (1-30)
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_green,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-1f, -firstStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -1f;
            fish.GetComponent<FishMovement>().bottom_limit = -firstStep;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_blue,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-1f, -firstStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -1f;
            fish.GetComponent<FishMovement>().bottom_limit = -firstStep;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_red,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-1f, -firstStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -1f;
            fish.GetComponent<FishMovement>().bottom_limit = -firstStep;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_yellow,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-1f, -firstStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -1f;
            fish.GetComponent<FishMovement>().bottom_limit = -firstStep;
        }

        // Second step (31-60)
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_green,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-firstStep-1, -secondStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -firstStep - 1;
            fish.GetComponent<FishMovement>().bottom_limit = -secondStep;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_blue,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-firstStep-1, -secondStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -firstStep - 1;
            fish.GetComponent<FishMovement>().bottom_limit = -secondStep;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_red,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-firstStep-1, -secondStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -firstStep - 1;
            fish.GetComponent<FishMovement>().bottom_limit = -secondStep;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_yellow,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-firstStep-1, -secondStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -firstStep - 1;
            fish.GetComponent<FishMovement>().bottom_limit = -secondStep;
        }

        // Second step (61-90)
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_green,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-secondStep-1, -thirdStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -secondStep - 1;
            fish.GetComponent<FishMovement>().bottom_limit = -thirdStep;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_blue,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-secondStep-1, -thirdStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -secondStep - 1;
            fish.GetComponent<FishMovement>().bottom_limit = -thirdStep;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_red,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-secondStep-1, -thirdStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -secondStep - 1;
            fish.GetComponent<FishMovement>().bottom_limit = -thirdStep;
        }
        for (int i = 0; i < 10; i++)
        {
            GameObject fish =
            Instantiate(fish_yellow,
            new Vector2(Random.Range(-40f, 40f), Random.Range(-secondStep-1, -thirdStep)),
            Quaternion.identity) as GameObject;
            fish.GetComponent<FishMovement>().top_limit = -secondStep - 1;
            fish.GetComponent<FishMovement>().bottom_limit = -thirdStep;
        }
    }
	
	void Update () {
		
	}
}
