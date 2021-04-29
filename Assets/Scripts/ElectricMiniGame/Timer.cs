
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

//Set a time

{
   [SerializeField] float limit;
    //( cuanto se tarda en llamar la 1a vez , después llamar a la funcion cada segundo )

    [SerializeField] Text textTime;
    [SerializeField] Button nextLevelButton;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("Countdown", 1, 1);
        //Get a reference to an instance of a class
        //Set the initial time
       textTime.text = "Time: " + limit;
    }

    void Countdown()
    {
      limit--;
      textTime.text = "Time: " + limit;
      if (limit <= 0){
          print ("Game Over");
          //Stop calling Countdown() method, detiene el contador
          CancelInvoke();
          nextLevelButton.gameObject.GetComponent <ChangeScene> ().nextSceneName="Final 2"; //en caso de perder
          nextLevelButton.gameObject.SetActive(true);
        }
    }
}



