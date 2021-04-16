using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This class will hold any information that each dialog needs 

[System.Serializable]
public class Dialog
{
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;
}
