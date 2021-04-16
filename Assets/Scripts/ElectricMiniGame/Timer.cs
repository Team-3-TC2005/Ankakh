/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour

Set a time

{
   [SerializeField] float limit;
    //( cuanto se tarda en llamar la 1a vez , después llamar a la funcion cada segundo )

    //Variable with the type of another script
   [SerializeField] WireConnection gameCompleted;

    [SerializeField] Text textTime;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("Countdown", 1, 1);
        //Get a reference to an instance of a class
        //Set the initial text
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
          //StopDrop => stop throwing balls, está en el script de dropballs
          //dropper.StopDrop();
          lightOn.SetActive(true);
        }
    }
}
*/


