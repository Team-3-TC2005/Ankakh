using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectionMenu : MonoBehaviour
{
    private string majorChosen;
    [SerializeField] public wwwFormGameData wwwForm;


    public void GameSelector(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void StartGame()
    {
        // This block is going to save the sprite selected by the user so it can be used other scenes

        GameObject character = GameObject.Find("Character Selector");
        CharacterSelector characterSelector = character.GetComponent<CharacterSelector>();

        GameSettings.Image = CharacterSelector.GetSprite();

        // Set name 
        GameObject playerName = GameObject.Find("Player Name");
        GameObject inputText = GameObject.Find("Text");
        GameSettings.Name = inputText.GetComponent<Text>().text;
        StartCoroutine(wwwForm.uploadData());

        // This block decide what the context of the game is going to be

        GameObject major = GameObject.Find("Major Selector");
        MajorSelector majorSelector = major.GetComponent<MajorSelector>();

        majorChosen = MajorSelector.GetMajor();

        if (majorChosen == "Ingeniería Electrónica")
        {
            GameSelector("Eleccion_1");
            //GameSelector(majorChosen);
        }
    }
}
