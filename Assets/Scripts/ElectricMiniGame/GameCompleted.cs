using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCompleted : MonoBehaviour
{

    public int valueToWin;
    private int activeLights = 0;
    public Button DialogueTrigger;
    public Button nextLevelButton;
    public Button startGameDialog;
    public string winLevel;

    void Start() 
    {
        startGameDialog.GetComponent<Button>().onClick.Invoke();
    }


    public void TriggerDialogueBox()
    {
        activeLights++;
        if (activeLights == valueToWin*2)
        {
            DialogueTrigger.GetComponent<Button>().onClick.Invoke();
            readyToNextLevel();
        }
        return;
    }

    private void readyToNextLevel()
    {
        //Reference to script ChangeScene
        nextLevelButton.gameObject.GetComponent <ChangeScene> ().nextSceneName=winLevel; //nos lleva a donde dice la variable
        nextLevelButton.gameObject.SetActive(true);
    }

    

}