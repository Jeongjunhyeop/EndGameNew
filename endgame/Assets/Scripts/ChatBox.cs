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

    public string[] sentence_fall;
    public string[] sentence_fall_sry;
    public string[] sentence_thx;
    public string[] sentence_st3;

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

    public void Talk_fall()
    {
        GameObject go = Instantiate(chatboxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentence_fall, chat_xy);
    }

    public void Talk_sry()
    {
        GameObject go = Instantiate(chatboxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentence_fall_sry, chat_xy);
    }

    public void Thanks()
    {
        GameObject go = Instantiate(chatboxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentence_thx, chat_xy);
    }

    public void hello()
    {
        GameObject go = Instantiate(chatboxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentence_st3, chat_xy);
    }

}
