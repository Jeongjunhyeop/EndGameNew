using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBox : MonoBehaviour
{

    public string[] sentence;
    public string[] sentence_apple;
    public string[] sentence_platform;
    public string[] sentence_danger;
    public string[] sentence_bird;

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

    public void Talk_platform()
    {
        GameObject go = Instantiate(chatboxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentence_platform, chat_xy);
    }

    public void Talk_bird()
    {
        GameObject go = Instantiate(chatboxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentence_bird, chat_xy);
    }

    public void Talk_danger()
    {
        GameObject go = Instantiate(chatboxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentence_danger, chat_xy);
    }

    private void OnMouseDown()
    {
        Talk();
    }
}
