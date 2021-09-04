using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFollow : MonoBehaviour
{
    public Transform Target;

    float Speed = 10f;

    const float EPSILON = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target.position);

        if((transform.position - Target.position).magnitude > EPSILON)
            transform.Translate(0.0f,0.0f, Speed*Time.deltaTime);
    }
}
