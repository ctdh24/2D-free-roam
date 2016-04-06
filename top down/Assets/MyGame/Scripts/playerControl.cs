using UnityEngine;
using System.Collections;

[System.Serializable]
public class Bounds
{
    public float xMin, xMax;
}

public class playerControl : MonoBehaviour {

    public Transform[] shotEmitter;
    public GameObject bullet;
    public float speed;
    public float tilt;
    public Bounds bounds;
    private float yPosition;

    void Start()
    {
        yPosition = transform.position.y;
    }

    //work on shooting here
    void Update()
    {
        if(transform.position.y != yPosition)
        {
            transform.position = new Vector3 (transform.position.x, yPosition, transform.position.z);
        }
    }
    //movement here
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody>().velocity = new Vector3(moveHorizontal*speed, 0.0f, 5.0f);

        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, bounds.xMin, bounds.xMax),
            0.0f,
            transform.position.z
        );

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
    }
}
