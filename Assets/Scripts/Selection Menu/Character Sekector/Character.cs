using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Set sprite to sprite selected during the character selection menu.
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = GameSettings.Image;
    }

}
