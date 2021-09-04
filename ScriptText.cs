using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptText : MonoBehaviour
{
    private TextMesh tm;
    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<TextMesh> ();
        tm.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey);
        {
            tm.text = tm.text + Input.inputString;
        }
    }
}
