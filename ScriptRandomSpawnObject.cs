using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRandomSpawnObject : MonoBehaviour
{   
    public GameObject go;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(Random.Range(2100,2105),210,Random.Range(-1872,-1868));
        if(Input.GetKeyDown (KeyCode.Q))
            Instantiate (go,pos,transform.rotation);
    }
}
