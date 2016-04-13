using UnityEngine;
using System.Collections;

public class endGoal : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            //player has reached goal
            _GameManager.goalReached = true;
        }
    }

}
