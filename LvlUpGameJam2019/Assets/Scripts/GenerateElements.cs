using UnityEngine;

public class GenerateElements : MonoBehaviour
{

    public Transform player;

    public GameObject fish_green;
    public GameObject fish_blue;
    public GameObject fish_red;
    public GameObject fish_yellow;

    public GameObject fish_r_bee;
    public GameObject fish_r_blue;
    public GameObject fish_r_overkitch;
    public GameObject fish_r_yellow;
    public GameObject fish_r_red;
    public GameObject fish_r_green;

    public GameObject fish_tr_blue;
    public GameObject fish_tr_yellow;
    public GameObject fish_tr_orange;
    public GameObject fish_tr_pink;

    public GameObject fish_final;

    public float spawn_zone_width = 50f;

    void Start()
    {

        for (int i = 0; i < 50; i++)
        {
            GameObject fishGreen =
            Instantiate(fish_green) as GameObject;
            fishGreen.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishGreen.GetComponent<FishMovement>().top_limit, fishGreen.GetComponent<FishMovement>().bottom_limit));
            GameObject fishBlue =
            Instantiate(fish_blue) as GameObject;
            fishBlue.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishBlue.GetComponent<FishMovement>().top_limit, fishBlue.GetComponent<FishMovement>().bottom_limit));
            GameObject fishRed =
            Instantiate(fish_red) as GameObject;
            fishRed.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishRed.GetComponent<FishMovement>().top_limit, fishRed.GetComponent<FishMovement>().bottom_limit));
            GameObject fishYellow =
            Instantiate(fish_yellow) as GameObject;
            fishYellow.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishYellow.GetComponent<FishMovement>().top_limit, fishYellow.GetComponent<FishMovement>().bottom_limit));
        }

        for (int i = 0; i < 30; i++)
        {
            GameObject fishRBee =
            Instantiate(fish_r_bee) as GameObject;
            fishRBee.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishRBee.GetComponent<FishMovement>().top_limit, fishRBee.GetComponent<FishMovement>().bottom_limit));
            GameObject fishRBlue =
            Instantiate(fish_r_blue) as GameObject;
            fishRBlue.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishRBlue.GetComponent<FishMovement>().top_limit, fishRBlue.GetComponent<FishMovement>().bottom_limit));
            GameObject fishROverkitch =
            Instantiate(fish_r_overkitch) as GameObject;
            fishROverkitch.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishROverkitch.GetComponent<FishMovement>().top_limit, fishROverkitch.GetComponent<FishMovement>().bottom_limit));
            GameObject fishRYellow =
            Instantiate(fish_r_yellow) as GameObject;
            fishRYellow.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishRYellow.GetComponent<FishMovement>().top_limit, fishRYellow.GetComponent<FishMovement>().bottom_limit));
            GameObject fishRRed =
            Instantiate(fish_r_red) as GameObject;
            fishRRed.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishRRed.GetComponent<FishMovement>().top_limit, fishRRed.GetComponent<FishMovement>().bottom_limit));
            GameObject fishRGreen =
            Instantiate(fish_r_green) as GameObject;
            fishRGreen.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishRGreen.GetComponent<FishMovement>().top_limit, fishRGreen.GetComponent<FishMovement>().bottom_limit));
        }

        for (int i = 0; i < 10; i++)
        {
            GameObject fishTRBlue =
            Instantiate(fish_tr_blue) as GameObject;
            fishTRBlue.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishTRBlue.GetComponent<FishMovement>().top_limit, fishTRBlue.GetComponent<FishMovement>().bottom_limit));
            GameObject fishTRYellow =
            Instantiate(fish_tr_yellow) as GameObject;
            fishTRYellow.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishTRYellow.GetComponent<FishMovement>().top_limit, fishTRYellow.GetComponent<FishMovement>().bottom_limit));
            GameObject fishTROrange =
            Instantiate(fish_tr_orange) as GameObject;
            fishTROrange.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishTROrange.GetComponent<FishMovement>().top_limit, fishTROrange.GetComponent<FishMovement>().bottom_limit));
            GameObject fishTRPink =
            Instantiate(fish_tr_pink) as GameObject;
            fishTRPink.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishTRPink.GetComponent<FishMovement>().top_limit, fishTRPink.GetComponent<FishMovement>().bottom_limit));
        }

        GameObject fishFinal =
        Instantiate(fish_final) as GameObject;
        fishFinal.transform.position = new Vector2(Random.Range(-spawn_zone_width, spawn_zone_width), Random.Range(fishFinal.GetComponent<FishMovement>().top_limit, fishFinal.GetComponent<FishMovement>().bottom_limit));
    }

    void Update()
    {

    }
}
