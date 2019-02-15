using UnityEngine;
using UnityEngine.UI;

public class ShowValY : MonoBehaviour {

    public Transform player;
    public Text yValText;
	
	void Update () {
        yValText.text = (player.position.y * 10).ToString("0");
    }
}
