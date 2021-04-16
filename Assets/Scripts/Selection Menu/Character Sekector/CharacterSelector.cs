using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    // Sprite selected
    private static Image image;

    public Button left;
    public Button rigth;

    // Collection of sprites that can be selected
    public Sprite[] images;
    private int index = 0;


    void Start() 
    {
        // Locate image component in which character sprites are going to be located.
        image = GameObject.Find("Image").GetComponent<Image>();
        image.sprite = images[index];
    }

    public void MoveLeft()
    {
        if (index == 0)
        {
            index = images.Length - 1;
        }else
        {
            index--;
        }
        image.sprite = images[index];
    }

    public void MoveRight()
    {
        if (index == images.Length - 1)
        {
            index = 0;
        }else
        {
            index++;
        }

        image.sprite = images[index];
    }

    public static Sprite GetSprite()
    {
        // Returns sprite selected
        return image.sprite;
    }

}
