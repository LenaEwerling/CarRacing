using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 20;
    private float horizontalInput;
    private float forwardInput;
    public int playerId;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + playerId);
        forwardInput = Input.GetAxis("Vertical" + playerId);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, forwardInput * turnSpeed * Time.deltaTime);

        // horizontalInput = Input.GetAxis("Horizontal");

        // transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
