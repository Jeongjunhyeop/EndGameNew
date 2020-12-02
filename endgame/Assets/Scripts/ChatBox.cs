using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBox : MonoBehaviour
{

    public string[] sentence;
    public string[] sentence_apple;
    public Transform chat_xy;
    public GameObject chatboxPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Talk()
    {
        GameObject go = Instantiate(chatboxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentence, chat_xy);
    }

    public void Talk_apple()
    {
        GameObject go = Instantiate(chatboxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentence_apple, chat_xy);
    }

    private void OnMouseDown()
    {
        Talk();
    }
}
