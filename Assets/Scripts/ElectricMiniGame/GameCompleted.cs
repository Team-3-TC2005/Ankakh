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
            // activated = true;
            readyToNextLevel();
        }
        return;
    }

    private void readyToNextLevel()
    {
        nextLevelButton.gameObject.SetActive(true);
    }

    

}
