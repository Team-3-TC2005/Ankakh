using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WireConnection : MonoBehaviour
{
    public GameObject gameCompleted;
    public SpriteRenderer wireEnd;
    public GameObject lightOn;
    Vector3 startPoint;
    Vector3 startPosition;
    public int sum;
    public int ready;

    // Start is called before the first frame update
    void Start()
    {
        ready = transform.parent.GetComponent<Wire>().ready;
        sum = transform.parent.GetComponent<Wire>().value;
        startPoint = transform.parent.position;
        startPosition = transform.position;
    }

    private void OnMouseDrag() 
    {
        // Mouse position
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        newPosition.z = 0;

        // Update Wire 
        UpdateWire(newPosition);
      
    }

    
    void Done()
    {
        // Turn on light
        lightOn.SetActive(true);
        gameCompleted.GetComponent<GameCompleted>().TriggerDialogueBox();
    }

    private void OnMouseUp() 
    {
        UpdateWire(startPosition);


        // Mouse position
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        newPosition.z = 0;

        // Check for nearby connection points
        Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, .2f);
        foreach (Collider2D collider in colliders)
        {

            // Make sure it's not our own
            if (collider.gameObject != gameObject)
            {
                // Update wire to the connection point position
                UpdateWire(collider.transform.position);

                sum += collider.transform.GetComponent<WireConnection>().sum;

                ready += collider.transform.GetComponent<WireConnection>().ready;
                

                if (sum == ready)
                {
                    collider.GetComponent<WireConnection>()?.Done();
                    Done();
                }


                return;
            }
        }

    }

    void UpdateWire(Vector3 newPosition)
    { 
        // Update Position

        transform.position = newPosition;

        // Update direccion 

        Vector3 direction = newPosition - startPoint;
        transform.right = direction * transform.lossyScale.x;

        // Update Scale 

        float dist = Vector2.Distance(startPoint, newPosition);

        wireEnd.size = new Vector2(dist, wireEnd.size.y);

    }

    

}