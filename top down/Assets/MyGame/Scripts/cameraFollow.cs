using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
    public GameObject player;
    private float yPos;
	// Use this for initialization
	void Start () {
        yPos = player.transform.position.y + 0.3f;
        transform.position = new Vector3(player.transform.position.x, yPos, player.transform.position.z - 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.3f, player.transform.position.z - 1.0f);
        if(transform.position.y != yPos)
            transform.position = new Vector3(player.transform.position.x, yPos, player.transform.position.z - 1.0f);
    }
}
