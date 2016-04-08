using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public class Bounds
{
    public float xMin, xMax;
}

public class playerControl : MonoBehaviour {

    public Transform[] shotEmitter;
    public GameObject bullet;
    public float maneuverSpeed;
    public float speed;
    public float tilt;
    public Bounds bounds;
    private float yPosition;

    public bool onBoostPad;
    public Slider boostMeter;
    public float boostPower = 50.0f;

    void Awake()
    {
        yPosition = transform.position.y;
        boostMeter.value = boostPower;
        onBoostPad = false;
    }

    //work on shooting here
    void Update()
    {
        if(transform.position.y != yPosition)
        {
            transform.position = new Vector3 (transform.position.x, yPosition, transform.position.z);
        }
        if (Input.GetButton("Fire1") && boostPower > 0 && !onBoostPad)
        {
            boostPower -= 0.5f;
            boostMeter.value = boostPower;
            gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }
    }
    //movement here
    void FixedUpdate()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody>().velocity = new Vector3(moveHorizontal*maneuverSpeed, 0.0f, speed);
        Debug.Log(GetComponent<Rigidbody>().velocity);
        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, bounds.xMin, bounds.xMax),
            0.0f,
            transform.position.z
        );

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
    }

    
}
