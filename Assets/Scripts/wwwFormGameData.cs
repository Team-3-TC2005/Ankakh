using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class wwwFormGameData : MonoBehaviour 
{
    // The route for the api that inserts data.
    private string apiURL = "http://localhost:5500/ankakh/";
    [SerializeField] string method;
    // References for the scripts that hold the information that is going to be inserted.


    // We need to start a coroutine that calls the request
    public IEnumerator uploadData()
    {
        // Unity sends a form, just as a html form. 
        WWWForm form = new WWWForm();

        // We need to create the form first, by manually adding fields. These fields match the names of the columns in the database.
        // The values from the other scripts is checked here and added to the form.\
        if (method == "addUser")
        {
            form.AddField("name", GameSettings.Name);
        }else if (method == "gameComplete")
        {
            form.AddField("name", GameSettings.Name);
            form.AddField("gameCompleted", 1);
        }


        Debug.Log(form);

        // We create a request that makes a post to the url, and sends the form we just created.
        using (UnityWebRequest request = UnityWebRequest.Post(apiURL + method, form))
        {
            // The yield return line is the point at which execution will pause, and be resumed after the request ends.
            yield return request.SendWebRequest();

            // If there are no errors...
            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log(request.error);
            }
            else
            {
                // We get the response text and log it in the console.
                Debug.Log(request.downloadHandler.text);
                Debug.Log("Form upload complete!");
            }
        }
    }

    public void Send()
    {
        StartCoroutine(uploadData());
    }

}
