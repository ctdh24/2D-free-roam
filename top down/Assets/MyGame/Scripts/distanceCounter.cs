using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class distanceCounter : MonoBehaviour {
    public GameObject player;
    private float timeElapsed = 0.0f;
    private float startTime;
    Text text;
    // Use this for initialization
    void Awake()
    {
        text = GetComponent<Text>();
    }
	// Update is called once per frame
	void FixedUpdate () {
        timeElapsed += Time.deltaTime;
        float min = Mathf.Floor(timeElapsed / 60f);
        float secs = Mathf.Floor(timeElapsed % 60f);
        text.text = string.Format("{00:00}:{1:00}", min, secs);
	}
}
