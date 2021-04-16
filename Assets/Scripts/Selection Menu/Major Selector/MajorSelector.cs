using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MajorSelector : MonoBehaviour
{
    private static TextMeshProUGUI text;

    public Button left;
    public Button rigth;

    public List<string> options = new List<string>();

    private int index = 0;


    void Start() 
    {
        text = GameObject.Find("Major").GetComponent<TextMeshProUGUI>();
        text.text = options[index];
    }

    public void MoveLeft()
    {
        if (index == 0)
        {
            index = options.Count - 1;
        }else
        {
            index--;
        }
        text.text = options[index];
    }

    public void MoveRight()
    {
        if (index == options.Count - 1)
        {
            index = 0;
        }else
        {
            index++;
        }

        text.text = options[index];
        print("Right");
    }

    public static string GetMajor()
    {
        return text.text;
    }

}
