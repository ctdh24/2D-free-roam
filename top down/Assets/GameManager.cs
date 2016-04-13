using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class _GameManager : MonoBehaviour {

	// Use this for initialization
    public static bool goalReached;
    public GameObject winScreen;
	void Start () {
        goalReached = false;
        winScreen.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (goalReached)
        {
            winScreen.SetActive(true);
            Time.timeScale = 0;
        }
	}
}
