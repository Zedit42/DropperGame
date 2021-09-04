using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDestroy : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision obj) {
        Destroy(obj.gameObject);
        Instantiate(go,transform.position,transform.rotation);

    }
}
