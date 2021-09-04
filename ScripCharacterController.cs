using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripCharacterController : MonoBehaviour
{
    public float speed=10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zAxis = Input.GetAxis("Vertical")*speed;
        float xAxis = Input.GetAxis("Horizontal")*speed;
        zAxis *= Time.deltaTime;
        xAxis *= Time.deltaTime;
        transform.Translate (zAxis,0,xAxis);

    }
}
