using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCharactherControlWithAddfForce : MonoBehaviour{
   
   
   private Rigidbody rb;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey (KeyCode.Space))
            rb.AddForce (new Vector3(0,10f,0));
        if(Input.GetKey (KeyCode.D))
            rb.AddForce (new Vector3(0,0,10f));
        if(Input.GetKey (KeyCode.A))
            rb.AddForce (new Vector3(0,0,-10f));
        if(Input.GetKey (KeyCode.W))
            rb.AddForce (new Vector3(-10f,0,0));
        if(Input.GetKey (KeyCode.S))
            rb.AddForce (new Vector3(10f,0,0));
    }
}
