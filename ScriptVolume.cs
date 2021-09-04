using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptVolume : MonoBehaviour
{
    AudioSource aSource;
    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            aSource.Pause () ;
        }
        if(Input.GetKeyDown(KeyCode.O)){
            aSource.Play () ;
        }
    }
}
