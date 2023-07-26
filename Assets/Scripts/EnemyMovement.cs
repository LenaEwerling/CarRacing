using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    private bool isAbovePoint = false;
    private float point = 180.0f;
    private float speed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAbovePoint && (player1.transform.position.z >= point || player2.transform.position.z >= point) ){
            isAbovePoint = true;
            Debug.Log("reached 180z");
        }
        if (isAbovePoint){
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
