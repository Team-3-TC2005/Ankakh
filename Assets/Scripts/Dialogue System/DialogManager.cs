using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    public Text Name;
    public Text DialogueBox;

    public bool animate;
    
    public Animator animator;
    // This variable will keep track of all our sentences

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog (Dialog dialogue)
    {

        if (animate)
        {
            animator.SetBool("isOpen", true);
        }


        Name.text = dialogue.name;


        // Clears sentences that where in our object form a previous conversation (Basicly making sure our object is clear before we load a new dialogue)
        sentences.Clear();

        // Loop through the sentences in our dialogue and adding them to our queue (Getting them ready to be shown on screen)
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {

        // Check if we have said every thing
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();


        // If a sentence has not finish with its animation stop that animation and start with the next one.
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        DialogueBox.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            DialogueBox.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {

        // Bring dialogue box down if we specified that we want our dialogue box to be animated
        if(animate)
        {
            animator.SetBool("isOpen", false);
        }

    }
}