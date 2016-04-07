using UnityEngine;
using System.Collections;

public class boostPad : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("BOOST");
            col.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }
    }
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("BOOST");
            col.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }
    }
}
