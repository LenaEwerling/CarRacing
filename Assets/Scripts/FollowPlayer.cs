using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -5);
    private bool kameraView = false;
    public KeyCode switchkey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    void Update()
    {
        if (Input.GetKeyDown(switchkey))
        {
            // Toggle between option 1 and option 2
            if (kameraView)
            {
                // Option 2 is active, switch to behind view
                Debug.Log("Switched to behind view");
                offset = new Vector3(0, 5, -5);
                //transform.Rotate(0, 90, 0);
                kameraView = false;
            }
            else
            {
                // Option 1 is active, switch to cabin view
                Debug.Log("Switched to cabin view");
                offset = new Vector3(0, 2, 2);
                //transform.Rotate(0, -90, 0);
                kameraView = true;
            }
        }
    }
}
