using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Choice : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public string Next1;
    public string Next2;
    public int ChoiceMade;

    public void ChoiceOption1 () {
         //TextBox.GetComponent<Text>().text ="A desayunar será";
         ChoiceMade = 1;
         SceneManager.LoadScene(Next1);
    }

    public void ChoiceOption2 () {
         //TextBox.GetComponent<Text>().text ="A trabajar será";
         ChoiceMade = 2;
         SceneManager.LoadScene(Next2);
    }

    // Update is called once per frame
    void Update()
    {
        if (ChoiceMade >= 1){
            Choice01.SetActive(false);
            Choice02.SetActive(false);
        }
    }
}
