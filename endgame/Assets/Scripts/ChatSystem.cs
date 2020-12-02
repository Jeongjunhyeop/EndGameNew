using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChatSystem : MonoBehaviour
{
    public Queue<string> sentences;
    public string currentSentence;
    public TextMeshPro text;
    public GameObject quad;

    public void Ondialogue(string[] lines, Transform chatpoint)
    {
        transform.position = chatpoint.position;
        sentences = new Queue<string>();
        sentences.Clear();
        foreach (var line in lines)
        {
            sentences.Enqueue(line);
        }
        StartCoroutine(DialogueFlow(chatpoint));
    }

    IEnumerator DialogueFlow(Transform chatpoint)
    {
        yield return null;
        while (sentences.Count > 0)
        {
            currentSentence = sentences.Dequeue();
            text.text = currentSentence;

            float x = text.preferredWidth;
            x = (x > 3) ? 3 : x + 0.3f;
            quad.transform.localScale = new Vector2(x,text.preferredHeight + 0.3f);

            transform.position = new Vector2(chatpoint.position.x, chatpoint.position.y + text.preferredHeight/2);
            yield return new WaitForSeconds(2.5f);
        }
        Destroy(gameObject);
    }
}
