using UnityEngine;
using System.Collections;

public class boostPad : MonoBehaviour {
    private playerControl player;
    void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<playerControl>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("BOOST");
            player.onBoostPad = true;
            col.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
            if (player.boostPower < 100.0f)
            {
                if ((100.0f - player.boostPower) < 2.0f)
                {
                    player.boostPower += (100.0f - player.boostPower);
                    player.boostMeter.value = player.boostPower;
                }
                else
                {
                    player.boostPower += 2.0f;
                    player.boostMeter.value = player.boostPower;
                }
            }
        }
    }
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("BOOST");
            player.onBoostPad = true;
            col.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }
        if (player.boostPower < 100.0f)
        {
            if ((100.0f - player.boostPower) < 2.0f)
            {
                player.boostPower += (100.0f - player.boostPower);
                player.boostMeter.value = player.boostPower;
            }
            else
            {
                player.boostPower += 2.0f;
                player.boostMeter.value = player.boostPower;
            }
                
        }
    }
    void OnTriggerExit(Collider col)
    {
        player.onBoostPad = false;
    }
}
